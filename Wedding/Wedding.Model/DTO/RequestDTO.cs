using System.Text.Json.Serialization;
using Wedding.Utility.Constants;

namespace Wedding.Model.DTO;

public class RequestDTO
{
    [JsonPropertyName("api-type")]
    public StaticEnum.ApiType ApiType { get; set; } = StaticEnum.ApiType.GET;
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("data")]
    public object Data { get; set; }
    [JsonPropertyName("access-token")]
    public string AccessToken { get; set; }
    [JsonPropertyName("content-type")]
    public StaticEnum.ContentType ContentType { get; set; } = StaticEnum.ContentType.Json;
}
