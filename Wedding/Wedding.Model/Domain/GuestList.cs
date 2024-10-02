using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Wedding.Model.Domain;

public class GuestList
{
    [Key]
    public Guid GuestId { get; set; }
    [ForeignKey("GuestId"),  DeleteBehavior(DeleteBehavior.NoAction)] public virtual ICollection<Guest> Guests { get; set; }
    public Guid EventId { get; set; }
    [ForeignKey("EventId")] public Event Event { get; set; }
    public string GuestName { get; set; }
    public string AttendStatus { get; set; }
    public DateTime CheckinTime { get; set; }
    public string GuestGift { get; set; }
}
