using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tingee.Sdk.Types;

/// <summary>
/// JSON converter for enums that respects [EnumMember(Value = "...")] attributes.
/// System.Text.Json's built-in JsonStringEnumConverter ignores EnumMember on .NET 8.
/// </summary>
public sealed class JsonEnumMemberConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert.IsEnum || (Nullable.GetUnderlyingType(typeToConvert)?.IsEnum ?? false);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var enumType = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;
        var converterType = typeof(JsonEnumMemberConverter<>).MakeGenericType(enumType);
        var inner = (JsonConverter)Activator.CreateInstance(converterType)!;

        if (Nullable.GetUnderlyingType(typeToConvert) is not null)
        {
            var nullableType = typeof(NullableEnumConverter<>).MakeGenericType(enumType);
            return (JsonConverter)Activator.CreateInstance(nullableType, inner)!;
        }

        return inner;
    }
}

internal sealed class JsonEnumMemberConverter<T> : JsonConverter<T> where T : struct, Enum
{
    private static readonly ConcurrentDictionary<T, string> EnumToString = new();
    private static readonly ConcurrentDictionary<string, T> StringToEnum = new(StringComparer.OrdinalIgnoreCase);

    static JsonEnumMemberConverter()
    {
        foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var value = (T)field.GetValue(null)!;
            var attr = field.GetCustomAttribute<EnumMemberAttribute>();
            var name = attr?.Value ?? field.Name;
            EnumToString[value] = name;
            StringToEnum[name] = value;
        }
    }

    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var raw = reader.GetString()!;
            if (StringToEnum.TryGetValue(raw, out var val)) return val;
            throw new JsonException($"Unknown enum value '{raw}' for {typeof(T).Name}");
        }
        if (reader.TokenType == JsonTokenType.Number)
        {
            return (T)Enum.ToObject(typeof(T), reader.GetInt32());
        }
        throw new JsonException($"Cannot convert {reader.TokenType} to {typeof(T).Name}");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(EnumToString.GetOrAdd(value, v => v.ToString()));
    }
}

internal sealed class NullableEnumConverter<T> : JsonConverter<T?> where T : struct, Enum
{
    private readonly JsonConverter<T> _inner;

    public NullableEnumConverter(JsonConverter inner) => _inner = (JsonConverter<T>)inner;

    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.Null ? null : _inner.Read(ref reader, typeof(T), options);

    public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
    {
        if (value is null) writer.WriteNullValue();
        else _inner.Write(writer, value.Value, options);
    }
}
