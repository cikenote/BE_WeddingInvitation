using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreateGuestDTO
{
    [JsonPropertyName("guest-id")]
    public Guid GuestId { get; set; }
    [JsonPropertyName("log-id")]
    public Guid EventId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("attend")]
    public string Attend { get; set; }
    [JsonPropertyName("gift")]
    public string Gift { get; set; }
}
