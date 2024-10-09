using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CustomerFullInfoDTO
{
    [JsonPropertyName("customer-id")]
    public Guid? CustomerId { get; set; }
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("full-name")]
    public string? FullName { get; set; }
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("phone-number")]
    public string? PhoneNumber { get; set; }
    [JsonPropertyName("birth-date")]
    public DateTime? BirthDate { get; set; }
    [JsonPropertyName("avatar-url")]
    public string? AvatarUrl { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}
