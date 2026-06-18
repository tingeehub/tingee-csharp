using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tingee.Sdk.Http;

internal class NullToDefaultIntConverter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return 0;
        if (reader.TokenType == JsonTokenType.String && int.TryParse(reader.GetString(), out int result)) return result;
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int num)) return num;
        return 0;
    }
    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

internal class NullToDefaultLongConverter : JsonConverter<long>
{
    public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return 0;
        if (reader.TokenType == JsonTokenType.String && long.TryParse(reader.GetString(), out long result)) return result;
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out long num)) return num;
        return 0;
    }
    public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

internal class NullToDefaultDoubleConverter : JsonConverter<double>
{
    public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return 0;
        if (reader.TokenType == JsonTokenType.String && double.TryParse(reader.GetString(), out double result)) return result;
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetDouble(out double num)) return num;
        return 0;
    }
    public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}

internal class NullToDefaultBoolConverter : JsonConverter<bool>
{
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return false;
        if (reader.TokenType == JsonTokenType.String && bool.TryParse(reader.GetString(), out bool result)) return result;
        if (reader.TokenType == JsonTokenType.True) return true;
        if (reader.TokenType == JsonTokenType.False) return false;
        return false;
    }
    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) => writer.WriteBooleanValue(value);
}
