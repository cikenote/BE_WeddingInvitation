using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class CreateEmailTemplateDTO : UpdateEmailTemplateDTO
{
    [JsonPropertyName("template-name")]
    public string TemplateName { get; set; }
    [JsonPropertyName("sender-name")]
    public string? SenderName { get; set; }
    [JsonPropertyName("sender-email")]
    public string? SenderEmail { get; set; }
    [JsonPropertyName("category")]
    public string Category { get; set; }
    [JsonPropertyName("subject-line")]
    public string SubjectLine { get; set; }
    [JsonPropertyName("pre-header-text")]
    public string? PreHeaderText { get; set; }
    [JsonPropertyName("personalization-tags")]
    public string? PersonalizationTags { get; set; }
    [JsonPropertyName("body-content")]
    public string BodyContent { get; set; }
    [JsonPropertyName("footer-content")]
    public string? FooterContent { get; set; }
    [JsonPropertyName("call-to-action")]
    public string? CallToAction { get; set; }
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    [JsonPropertyName("recipient-type")]
    public string RecipientType { get; set; }
}