using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class AddToCartDTO
{
    [JsonPropertyName("card-id")]
    [Required] public Guid CardId { get; set; }
}