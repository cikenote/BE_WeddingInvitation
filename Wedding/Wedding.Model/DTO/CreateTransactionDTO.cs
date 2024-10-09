using System.Text.Json.Serialization;
using Wedding.Utility.Constants;

namespace Wedding.Model.DTO;

public class CreateTransactionDTO
{
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("type")]
    public StaticEnum.TransactionType Type { get; set; }
    [JsonPropertyName("amount")]
    public double Amount { get; set; }
}