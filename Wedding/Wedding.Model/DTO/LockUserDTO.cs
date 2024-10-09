using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class LockUserDTO
{
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
}
