using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class EventPhotoDTO
{
    [JsonPropertyName("event-photo-id")]
    public Guid EventPhotoId { get; set; }
    [JsonPropertyName("event-id")]
    public Guid EventId { get; set; }
    [JsonPropertyName("photo-url")]
    public string PhotoUrl { get; set; }
    [JsonPropertyName("photo-type")]
    public string PhotoType { get; set; }
    [JsonPropertyName("uploaded-date")]
    public DateTime UploadedDate { get; set; }
}
