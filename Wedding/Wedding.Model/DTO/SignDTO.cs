using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class SignDTO
{
    [JsonPropertyName("email")]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    [JsonPropertyName("password")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}
