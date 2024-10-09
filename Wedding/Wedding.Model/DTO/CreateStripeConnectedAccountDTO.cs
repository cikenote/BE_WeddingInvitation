using System.Text.Json.Serialization;
using Wedding.Utility.Constants;

namespace Wedding.Model.DTO;

public class CreateStripeConnectedAccountDTO
{
    [JsonPropertyName("refresh-url")]
    public string RefreshUrl { get; set; }
    [JsonPropertyName("return-url")]
    public string ReturnUrl { get; set; }
    [JsonPropertyName("email")]
    [JsonIgnore] public string? Email { get; set; }
}