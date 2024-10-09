using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CardManagementDTO
{
    [JsonPropertyName("card-id")]
    public Guid CardId { get; set; }
    [JsonPropertyName("user-id")]
    public string UserId { get; set; }
    [JsonPropertyName("invitation-id")]
    public Guid InvitationId { get; set; }
    [JsonPropertyName("attend-status")]
    public string AttendStatus { get; set; }
    [JsonPropertyName("created-time")]
    public DateTime CreatedTime { get; set; }
}