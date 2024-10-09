using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO
{
    public class UpdateCustomerDTO
    {
        [JsonPropertyName("customer-id")]
        [Required] public Guid CustomerId { get; set; }
        [JsonPropertyName("gender")]
        [Required] public string? Gender { get; set; }
        [JsonPropertyName("full-name")]
        [Required] public string? FullName { get; set; }
        [JsonPropertyName("birth-date")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        [JsonPropertyName("country")]
        [Required] public string? Country { get; set; }
        [JsonPropertyName("address")]
        [Required] public string? Address { get; set; }
    }
}