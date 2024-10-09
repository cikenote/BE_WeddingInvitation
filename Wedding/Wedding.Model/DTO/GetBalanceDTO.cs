using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class GetBalanceDTO
{
    [JsonPropertyName("total-balance")]
    public double TotalBalance { get; set; }
    [JsonPropertyName("available-balance")]
    public double AvailableBalance { get; set; }
    [JsonPropertyName("payout-balance")]
    public double PayoutBalance { get; set; }
    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}