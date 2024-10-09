using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateActivityLogDTO
{
    [JsonPropertyName("log-id")]
    public Guid LogId { get; set; }
    [JsonPropertyName("action")]
    public string Action { get; set; }
    [JsonPropertyName("entity")]
    public string Entity { get; set; }
    [JsonPropertyName("time-stamp")]
    public string TimeStamp { get; set; }
}