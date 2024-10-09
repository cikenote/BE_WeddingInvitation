using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class ResponseStripeConnectedAccountDTO
{
    [JsonPropertyName("account-id")]
    public string? AccountId { get; set; }
    [JsonPropertyName("account-link-url")]
    public string? AccountLinkUrl { get; set; }
}