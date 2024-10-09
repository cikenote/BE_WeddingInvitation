using System.Text.Json.Serialization;
using Wedding.Model.DTO;

namespace Wedding.Model.Domain;

public class CartHeaderDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("customer-id")]
    public Guid CustomerId { get; set; }
    [JsonPropertyName("total-price")]
    public double TotalPrice { get; set; }

    public IEnumerable<CartDetailsDTO> CartDetailsDtos { get; set; }
}