using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdatePrivacyDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("content")]
    public string Content { get; set; }
    [JsonPropertyName("is-active")]
    public bool IsActive { get; set; }
}