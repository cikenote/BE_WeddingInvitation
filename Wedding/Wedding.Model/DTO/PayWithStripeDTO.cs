using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class PayWithStripeDTO
{
    [JsonPropertyName("approve-url")]
    public string ApprovedUrl { get; set; }
    [JsonPropertyName("cancel-url")]
    public string CancelUrl { get; set; }
    [JsonPropertyName("order-header-id")]
    public Guid OrderHeaderId { get; set; }
}