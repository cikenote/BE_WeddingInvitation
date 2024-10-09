using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class InvitationDTO
{
    [JsonPropertyName("invitation-id")]
    public Guid InvitationId { get; set; }
    [JsonPropertyName("wedding-id")]
    public Guid WeddingId { get; set; }
    [JsonPropertyName("template-id")]
    public Guid TemplateId { get; set; }
    [JsonPropertyName("customer-message")]
    public string CustomerMessage { get; set; }
    [JsonPropertyName("customer-text-color")]
    public string CustomerTextColor { get; set; }
    [JsonPropertyName("shareable-link")]
    public string ShareableLink { get; set; }
    [JsonPropertyName("created-time")]
    public DateTime CreatedTime { get; set; }
}