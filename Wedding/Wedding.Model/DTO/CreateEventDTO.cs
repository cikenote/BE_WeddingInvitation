using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Wedding.Model.Domain;

namespace Wedding.Model.DTO;

public class CreateEventDTO
{
    [JsonPropertyName("event-id")]
    public Guid EventId { get; set; }
    [JsonPropertyName("wedding-id")]
    public Guid WeddingId { get; set; }
    [JsonPropertyName("bride-name")]
    public string BrideName { get; set; }
    [JsonPropertyName("groom-name")]
    public string GroomName { get; set; }
    [JsonPropertyName("event-date")]
    public DateTime EventDate { get; set; }
    [JsonPropertyName("event-location")]
    public string EventLocation { get; set; }
    [JsonPropertyName("event-photo-url")]
    public string EventPhotoUrl { get; set; }
    [JsonPropertyName("created-date")]
    public DateTime CreatedDate { get; set; }
}
