using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UserCom.Model.Attributes;
using UserCom.Model.Lists;
using UserCom.Model.Tags;

namespace UserCom.Model.Users
{
    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("companies")]
        public IReadOnlyList<UserCompany> Companies { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("linkedin_url")]
        public string? LinkedinUrl { get; set; }

        [JsonProperty("tags")]
        public IReadOnlyList<Tag> Tags { get; set; }

        [JsonProperty("last_contacted")]
        public DateTime? LastContacted { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("facebook_url")]
        public string? FacebookUrl { get; set; }

        [JsonProperty("notifications")]
        public bool Notifications { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }

        [JsonProperty("timezone")]
        public string? Timezone { get; set; }

        [JsonProperty("status")]
        public UserStatus Status { get; set; }

        [JsonProperty("gravatar_url")]
        public string? GravatarUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string? TwitterUrl { get; set; }

        [JsonProperty("google_url")]
        public string? GoogleUrl { get; set; }

        [JsonProperty("os_type")]
        public string? OsType { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("unsubscribed")]
        public bool Unsubscribed { get; set; }

        [JsonProperty("first_seen")]
        public DateTime? FirstSeen { get; set; }

        [JsonProperty("page_views")]
        public int PageViews { get; set; }

        [JsonProperty("last_ip")]
        public string? LastIp { get; set; }

        [JsonProperty("browser")]
        public string? Browser { get; set; }

        [JsonProperty("gender")]
        public UserGender Gender { get; set; }

        [JsonProperty("resolution")]
        public string? Resolution { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("last_seen")]
        public DateTime? LastSeen { get; set; }

        [JsonProperty("lists")]
        public IReadOnlyList<List> Lists { get; set; }

        [JsonProperty("attributes")]
        public IReadOnlyList<AttributeValue> Attributes { get; set; }

        [JsonProperty("browser_language")]
        public string? BrowserLanguage { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        [JsonProperty("web_push_subscription")]
        public bool WebPushSubscription { get; set; }

        [JsonProperty("assigned_to")]
        public int? AssignedTo { get; set; }
    }
}