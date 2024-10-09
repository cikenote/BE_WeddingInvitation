using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CartDetailsDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("cart-header-id")]
    public Guid CartHeaderId { get; set; }
    [JsonPropertyName("card-id")]
    public Guid CardId { get; set; }
    [JsonPropertyName("card-price")]
    public double CardPrice { get; set; }
    [JsonPropertyName("card-title")]
    public string? CardTitle { get; set; }
}