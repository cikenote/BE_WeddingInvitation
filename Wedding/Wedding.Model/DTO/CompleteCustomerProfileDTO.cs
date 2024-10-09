using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CompleteCustomerProfileDTO
{
    [JsonPropertyName("country")]
    [Required]
    public string Country { get; set; }

    [JsonPropertyName("phone-number")]
    [Required]
    [Phone]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("address")]
    [Required]
    public string Address { get; set; }

    [JsonPropertyName("birth-date")]
    [Required]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }

    [JsonPropertyName("gender")]
    [Required]
    public string Gender { get; set; }

    [JsonPropertyName("card-number")]
    [Required]
    public string CardNumber { get; set; }

    [JsonPropertyName("card-provider")]
    [Required]
    public string CardProvider { get; set; }

    [JsonPropertyName("card-name")]
    [Required]
    public string CardName { get; set; }
}
