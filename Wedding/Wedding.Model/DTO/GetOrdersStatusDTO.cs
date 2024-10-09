using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class GetOrdersStatusDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("created-time")]
    public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
    [JsonPropertyName("created-by")]
    public string? CreatedBy { get; set; }
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