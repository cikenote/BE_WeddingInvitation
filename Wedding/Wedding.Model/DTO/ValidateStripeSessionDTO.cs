using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class ValidateStripeSessionDTO
{
    [JsonPropertyName("stripe-session-id")]
    public string? StripeSessionId { get; set; }
    [JsonPropertyName("payment-intent-id")]
    public string? PaymentIntentId { get; set; }
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}