using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class ResponseStripeSessionDTO
{
    [JsonPropertyName("stripe-session-id")]
    public string? StripeSessionId { get; set; }
    [JsonPropertyName("stripe-session-url")]
    public string? StripeSessionUrl { get; set; }
}