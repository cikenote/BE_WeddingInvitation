using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreateStripeTransferDTO
{
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("connected-account-id")]
    [JsonIgnore] public string? ConnectedAccountId { get; set; }
    [JsonPropertyName("amount")]
    public long Amount { get; set; }
    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}