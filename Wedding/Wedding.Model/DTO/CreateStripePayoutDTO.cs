using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreateStripePayoutDTO
{
    [JsonIgnore]
    public string? ConnectedAccountId { get; set; }
    [JsonPropertyName("amount")]
    public long Amount { get; set; }
    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}