using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class JwtTokenDTO
{
    [JsonPropertyName("access-token")]
    public string AccessToken { get; set; }
    [JsonPropertyName("refresh-token")]
    public string RefreshToken { get; set; }
}
