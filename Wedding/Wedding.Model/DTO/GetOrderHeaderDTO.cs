using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class GetOrderHeaderDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("customer-id")]
    public Guid CustomerId { get; set; }
    [JsonPropertyName("order-price")]
    public double OrderPrice { get; set; }
    [JsonPropertyName("payment-intent-id")]
    public string? PaymentIntentId { get; set; }
    [JsonPropertyName("stripe-session-id")]
    public string? StripeSessionId { get; set; }
    [JsonPropertyName("created-by")]
    public string? CreatedBy { get; set; }
    [JsonPropertyName("created-time")]
    public DateTime? CreatedTime { get; set; }
    [JsonPropertyName("updated-by")]
    public string? UpdatedBy { get; set; }
    [JsonPropertyName("updated-time")]
    public DateTime? UpdatedTime { get; set; }
    [JsonPropertyName("status")]
    public int? Status { get; set; }
    public IEnumerable<GetOrderDetailsDTO>? GetOrderDetails { get; set; }
    [JsonPropertyName("status-description")]
    public string StatusDescription
    {
        get
        {
            return Status switch
            {
                0 => "Pending",
                1 => "Paid",
                2 => "Confirmed",
                3 => "Rejected",
                4 => "PendingRefund",
                5 => "ConfirmedRefund",
                6 => "RejectedRefund",
                _ => "Pending"
            };
        }
    }
}