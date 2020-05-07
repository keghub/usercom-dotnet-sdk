#nullable enable

using Newtonsoft.Json;

namespace UserCom.Model.Users.Requests
{
    public class UpdateOrCreateUserRequest
    {
        [JsonProperty("assigned_to")]
        public int? AssignedTo { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("facebook_url")]
        public string? FacebookUrl { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("gender")]
        public UserGender? Gender { get; set; }

        [JsonProperty("google_url")]
        public string? GoogleUrl { get; set; }

        [JsonProperty("gravatar_url")]
        public string? GravatarUrl { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("linkedin_url")]
        public string? LinkedinUrl { get; set; }

        [JsonProperty("notifications")]
        public bool? Notifications { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("status")]
        public UserStatus? Status { get; set; }

        [JsonProperty("timezone")]
        public string? Timezone { get; set; }

        [JsonProperty("twitter_url")]
        public string? TwitterUrl { get; set; }

        [JsonProperty("unsubscribed")]
        public bool? Unsubscribed { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}