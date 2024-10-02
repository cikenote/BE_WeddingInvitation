using System.ComponentModel.DataAnnotations;

namespace Wedding.Model.DTO;

public class SendVerifyEmailDTO
{
    [EmailAddress]
    public string Email { get; set; }
}