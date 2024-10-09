using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpsertBalanceDTO
{
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("available-balance")]
    public double AvailableBalance { get; set; }
    [JsonPropertyName("payout-balance")]
    public double PayoutBalance { get; set; }
    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}