using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateInvitationTemplateDTO
{
    [JsonPropertyName("template-id")]
    public Guid TemplateId { get; set; }
    [JsonPropertyName("template-name")]
    public string TemplateName { get; set; }
    [JsonPropertyName("background-image-url")]
    public string BackgroundImageUrl { get; set; }
    [JsonPropertyName("text-color")]
    public string TextColor { get; set; }
    [JsonPropertyName("text-font")]
    public string TextFont { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("created-by")]
    public DateTime CreatedBy { get; set; }
}