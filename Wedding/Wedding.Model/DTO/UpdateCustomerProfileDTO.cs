using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateCustomerProfileDTO
{
    [JsonPropertyName("gender")]
    [Required]
    public string? Gender { get; set; }

    [JsonPropertyName("full-name")]
    [Required]
    public string? FullName { get; set; }

    [JsonPropertyName("birth-date")]
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime? BirthDate { get; set; }

    [JsonPropertyName("country")]
    [Required]
    public string? Country {  get; set; }

    [JsonPropertyName("address")]
    [Required]
    public string? Address { get; set; }

    [JsonPropertyName("card-number")]
    [Required]
    public string? CardNumber { get; set; }

    [JsonPropertyName("card-name")]
    [Required]
    public string? CardName { get; set; }

    [JsonPropertyName("card-provider")]
    [Required]
    public string? CardProvider { get; set; }
}
