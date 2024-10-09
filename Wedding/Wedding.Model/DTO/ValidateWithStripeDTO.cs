using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class ValidateWithStripeDTO
{
    [JsonPropertyName("order-header-id")]
    public Guid OrderHeaderId { get; set; }
}