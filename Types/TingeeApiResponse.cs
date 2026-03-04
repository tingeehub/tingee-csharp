namespace Tingee.Sdk.Types;

public class TingeeApiResponse
{
    public string? Code { get; set; }
    public string? Message { get; set; }
    public object? Data { get; set; }

    public bool IsSuccess => Code == "00";
    public bool IsError => !IsSuccess;
}

public class TingeeApiResponse<T>
{
    public string? Code { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }

    public bool IsSuccess => Code == "00";
    public bool IsError => !IsSuccess;
}

public class TingeeHttpException : Exception
{
    public int StatusCode { get; }
    public object? ResponseData { get; }
    public IReadOnlyDictionary<string, string> Headers { get; }

    public TingeeHttpException(
        string message,
        int statusCode,
        object? responseData,
        IReadOnlyDictionary<string, string> headers,
        Exception? innerException = null)
        : base(message, innerException)
    {
        StatusCode = statusCode;
        ResponseData = responseData;
        Headers = headers;
    }
}

