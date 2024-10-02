namespace Wedding.Model.DTO;

public class CreateInvitationTemplateDTO
{
    public Guid TemplateId { get; set; }
    public string TemplateName { get; set; }
    public string BackgroundImageUrl { get; set; }
    public string TextColor { get; set; }
    public string TextFont { get; set; }
    public string Description { get; set; }
    public DateTime CreatedBy { get; set; }
}