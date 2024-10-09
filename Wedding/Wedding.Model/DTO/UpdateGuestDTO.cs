using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateGuestDTO
{
    [JsonPropertyName("guest-id")]
    public Guid GuestId { get; set; }
    [JsonPropertyName("event-id")]
    public Guid EventId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("attend")]
    public string Attend { get; set; }
    [JsonPropertyName("gift")]
    public string Gift { get; set; }
}
