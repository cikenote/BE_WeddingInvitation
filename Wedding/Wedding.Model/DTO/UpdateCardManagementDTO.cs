using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class UpdateCardManagementDTO
{
    [JsonPropertyName("card-id")]
    public Guid CardId { get; set; }
    [JsonPropertyName("invitation-id")]
    public Guid InvitationId { get; set; }
    [JsonPropertyName("attend-status")]
    public string AttendStatus { get; set; }
    [JsonPropertyName("created-time")]
    public DateTime CreatedTime { get; set; }
}