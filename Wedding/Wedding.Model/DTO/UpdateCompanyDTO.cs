using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateCompanyDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("address")]
    public string Address { get; set; }
    [JsonPropertyName("city")]
    public string City { get; set; }
    [JsonPropertyName("state")]
    public string State { get; set; }
    [JsonPropertyName("country")]
    public string Country { get; set; }
    [JsonPropertyName("postal-code")]
    public string PostalCode { get; set; }
    [JsonPropertyName("phone")]
    public string Phone { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("website")]
    public string Website { get; set; }
    [JsonPropertyName("founded-date")]
    public DateTime FoundedDate { get; set; }
    [JsonPropertyName("logo-url")]
    public string LogoUrl { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
}