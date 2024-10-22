using System.Text.Json.Serialization;

namespace Wedding.Model.DTO
{
    public class SignResponseDTO
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
