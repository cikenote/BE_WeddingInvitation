using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateTermOfUseDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("content")]
    public string Content { get; set; }
    [JsonPropertyName("isActive")]
    public bool IsActive { get; set; }
}