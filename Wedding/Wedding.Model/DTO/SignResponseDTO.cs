using System.Text.Json.Serialization;

namespace Wedding.Model.DTO
{
    public class SignResponseDTO
    {
        [JsonPropertyName("access-toekn")]
        public string AccessToken { get; set; }
        [JsonPropertyName("refresh-token")]
        public string RefreshToken { get; set; }
    }
}
