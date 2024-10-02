using System.ComponentModel.DataAnnotations;

namespace Wedding.Model.DTO;

public class AddToCartDTO
{
    [Required] public Guid CardId { get; set; }
}