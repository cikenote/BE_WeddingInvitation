using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class ActivityLogDTO
{
    [JsonPropertyName("log-id")]
    public Guid LogId { get; set; }
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("action")]
    public string Action { get; set; }
    [JsonPropertyName("entity")]
    public string Entity { get; set; }
    [JsonPropertyName("entity-id")]
    public string TimeStamp { get; set; }
}