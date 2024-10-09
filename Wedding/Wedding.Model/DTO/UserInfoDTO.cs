using System.Text.Json.Serialization;

namespace Wedding.Model.DTO
{
    public class UserInfoDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("customer-id")]
        public Guid? CustomerId { get; set; }
        [JsonPropertyName("user-name")]
        public string UserName { get; set; }
        [JsonPropertyName("full-name")]
        public string FullName { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("birthdate")]
        public DateTime Birthdate { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("phone-number")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("avatar-url")]
        public string AvatarUrl { get; set; }
        [JsonPropertyName("create-time")]
        public DateTime UpdateTime { get; set; }
        [JsonPropertyName("is-update-time")]
        public bool isUploadDegree { get; set; }
        [JsonPropertyName("is-accepted")]
        public bool? isAccepted { get; set; } = false;
        public IEnumerable<string> Roles { get; set; }
    }
}
