using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreateOrderStatusDTO
{
    [JsonPropertyName("order-header-id")]
    public Guid OrderHeaderId { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
}