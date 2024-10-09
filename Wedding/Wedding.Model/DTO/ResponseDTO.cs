using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;
public class ResponseDTO
{
    [JsonPropertyName("result")]
    public object? Result { get; set; }
    [JsonPropertyName("is-success")]
    public bool IsSuccess { get; set; }
    [JsonPropertyName("status-code")]
    public int StatusCode { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
}
