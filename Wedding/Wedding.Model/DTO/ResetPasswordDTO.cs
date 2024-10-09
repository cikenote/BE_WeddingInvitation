using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Wedding.Utility.ValidationAttribute;

namespace Wedding.Model.DTO;

public class ResetPasswordDTO
{
    //[Required(ErrorMessage = "Email is required")]
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("token")]
    //[Required(ErrorMessage = "Token is required")]
    public string Token { get; set; }

    [JsonPropertyName("password")]
    /*[Required(ErrorMessage = "New Password is required")]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "New password must be at least 8 characters long.")]
    [Password]*/
    public string Password { get; set; }
    /*[Required(ErrorMessage = "New Password is required")]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "New password must be at least 8 characters long.")]
    [Password]*/
    //public string ConfirmPassword { get; set; }
}
