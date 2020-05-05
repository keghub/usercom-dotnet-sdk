#nullable enable
using System;
using System.Collections.Generic;
using UserCom.Model.Attributes;
using UserCom.Model.Lists;
using UserCom.Model.Tags;

namespace UserCom.Model.Users
{
    public class User
    {
        public string Email { get; set; }

        public DateTime UpdatedAt { get; set; }

        public IReadOnlyList<UserCompany> Companies { get; set; }

        public string Key { get; set; }

        public string? City { get; set; }

        public string? LinkedinUrl { get; set; }

        public IReadOnlyList<Tag> Tags { get; set; }

        public DateTime? LastContacted { get; set; }

        public string? PhoneNumber { get; set; }

        public string? FacebookUrl { get; set; }

        public bool Notifications { get; set; }

        public string? Region { get; set; }

        public string? Timezone { get; set; }

        public UserStatus Status { get; set; }

        public string? GravatarUrl { get; set; }

        public string? TwitterUrl { get; set; }

        public string? GoogleUrl { get; set; }

        public string? OsType { get; set; }

        public int Score { get; set; }

        public bool Unsubscribed { get; set; }

        public DateTime? FirstSeen { get; set; }

        public int PageViews { get; set; }

        public string? LastIp { get; set; }

        public string? Browser { get; set; }

        public UserGender Gender { get; set; }

        public string? Resolution { get; set; }

        public string? Country { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? LastSeen { get; set; }

        public IReadOnlyList<List> Lists { get; set; }

        public IReadOnlyList<AttributeValue> Attributes { get; set; }

        public string? BrowserLanguage { get; set; }

        public int Id { get; set; }

        public string? UserId { get; set; }

        public bool WebPushSubscription { get; set; }

        public int? AssignedTo { get; set; }
    }
}