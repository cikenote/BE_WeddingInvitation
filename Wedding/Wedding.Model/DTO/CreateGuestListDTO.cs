using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Wedding.Model.Domain;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreateGuestListDTO
{
    [JsonPropertyName("guest-id")]
    public Guid GuestId { get; set; }
    [JsonPropertyName("event-id")]
    public Guid EventId { get; set; }
    [JsonPropertyName("guest-name")]
    public string GuestName { get; set; }
    [JsonPropertyName("attend-status")]
    public string AttendStatus { get; set; }
    [JsonPropertyName("checkin-time")]
    public DateTime CheckinTime { get; set; }
    [JsonPropertyName("guest-gift")]
    public string GuestGift { get; set; }
}

