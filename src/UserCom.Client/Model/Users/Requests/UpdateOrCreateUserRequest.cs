#nullable enable

namespace UserCom.Model.Users.Requests
{
    public class UpdateOrCreateUserRequest
    {
        public int? AssignedTo { get; set; }

        public string? City { get; set; }

        public int? CompanyId { get; set; }

        public string? Country { get; set; }

        public string? Email { get; set; }

        public string? FacebookUrl { get; set; }

        public string? FirstName { get; set; }

        public UserGender? Gender { get; set; }

        public string? GoogleUrl { get; set; }

        public string? GravatarUrl { get; set; }

        public string? LastName { get; set; }

        public string? LinkedinUrl { get; set; }

        public bool? Notifications { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Region { get; set; }

        public int? Score { get; set; }

        public UserStatus? Status { get; set; }

        public string? Timezone { get; set; }

        public string? TwitterUrl { get; set; }

        public bool? Unsubscribed { get; set; }

        public string? UserId { get; set; }
    }
}