using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateWeddingDTO
{
    [JsonPropertyName("wedding-id")]
    public Guid WeddingId { get; set; }
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("bride-name")]
    public string BrideName { get; set; }
    [JsonPropertyName("groom-name")]
    public string GroomName { get; set; }
    [JsonPropertyName("wedding-date")]
    public DateTime WeddingDate { get; set; }
    [JsonPropertyName("wedding-location")]
    public string WeddingLocation { get; set; }
    [JsonPropertyName("wedding-photo-url")]
    public string WeddingPhotoUrl { get; set; }
    [JsonPropertyName("created-date")]
    public DateTime CreatedDate { get; set; }
}