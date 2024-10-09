using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class SignInByGoogleDTO
{
    [JsonPropertyName("token")]
    public string Token { get; set; }
}
