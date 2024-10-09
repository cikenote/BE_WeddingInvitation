using System.Text.Json.Serialization;
using Wedding.Model.Domain;

namespace Wedding.Model.DTO;

public class CreateStripeSessionDTO
{
    public IEnumerable<OrderDetails>? OrdersDetails { get; set; }
    [JsonPropertyName("approve-url")]
    public string? ApprovedUrl { get; set; }
    [JsonPropertyName("cancel-url")]
    public string? CancelUrl { get; set; }
}