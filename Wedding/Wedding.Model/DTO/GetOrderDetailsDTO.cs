using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class GetOrderDetailsDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("card-id")]
    public Guid CardId { get; set; }
    [JsonPropertyName("card-title")]
    public string? CardTitle { get; set; }
    [JsonPropertyName("card-price")]
    public double CardPrice { get; set; }
    [JsonPropertyName("order-header-id")]
    public Guid OrderHeaderId { get; set; }
}