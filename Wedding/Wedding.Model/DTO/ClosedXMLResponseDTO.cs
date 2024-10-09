using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class ClosedXMLResponseDTO
{
    [JsonPropertyName("stream")]
    public MemoryStream? Stream { get; set; }
    [JsonPropertyName("content-type")]
    public string? ContentType { get; set; }
    [JsonPropertyName("file-name")]
    public string? FileName { get; set; }
    [JsonPropertyName("status-code")]
    public int? StatusCode { get; set; }
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    [JsonPropertyName("is-success")]
    public bool IsSuccess { get; set; }
}