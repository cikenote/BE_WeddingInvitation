using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wedding.Model.DTO;

public class GuestDTO
{
    [JsonPropertyName("guest-id")]
    public Guid GuestId { get; set; }
    [JsonPropertyName("event-id")]
    public Guid EventId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("attend")]
    public string Attend { get; set; }
    [JsonPropertyName("gift")]
    public string Gift { get; set; }
}
