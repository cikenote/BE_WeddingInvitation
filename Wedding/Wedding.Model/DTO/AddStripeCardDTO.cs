using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class AddStripeCardDTO
{
    [JsonPropertyName("connected-account-id")]
    public string ConnectedAccountId { get; set; }
    [JsonPropertyName("card-token")]
    public string CardToken { get; set; }
}