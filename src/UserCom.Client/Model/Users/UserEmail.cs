using System;

namespace UserCom.Model.Users
{
    public class UserEmail
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? SentAt { get; set; }

        public DateTime? OpenedAt { get; set; }

        public DateTime? ClickedAt { get; set; }

        public string Subject { get; set; }
    }
}