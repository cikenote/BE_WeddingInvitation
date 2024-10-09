using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Wedding.Model.Domain;
using Wedding.Utility.Constants;

namespace Wedding.Model.DTO;

public class GetTransactionDTO
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("type")]
    public StaticEnum.TransactionType Type { get; set; }
    [JsonPropertyName("amount")]
    public double Amount { get; set; }
    [JsonPropertyName("currency")]
    public string Currency { get; set; }
    [JsonPropertyName("created-time")]
    public DateTime CreatedTime { get; set; }
    [JsonPropertyName("type-description")]
    public string TypeDescription
    {
        get
        {
            switch (Type)
            {
                case StaticEnum.TransactionType.Purchase:
                    {
                        return "Purchase";
                    }
                case StaticEnum.TransactionType.Income:
                    {
                        return "Income";
                    }
                case StaticEnum.TransactionType.Payout:
                    {
                        return "Payout";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}