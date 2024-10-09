using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreatePrivacyDTO
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("content")]
    public string Content { get; set; }
    [JsonPropertyName("is-active")]
    public bool IsActive { get; set; }
}