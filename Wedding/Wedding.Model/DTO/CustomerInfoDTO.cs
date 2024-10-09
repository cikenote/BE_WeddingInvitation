using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CustomerInfoDTO
{
    [JsonPropertyName("customer-id")]
    public Guid? CustomerId { get; set; }
    [JsonPropertyName("full-name")]
    public string? FullName { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("phone-number")]
    public string? PhoneNumber { get; set; }
}
