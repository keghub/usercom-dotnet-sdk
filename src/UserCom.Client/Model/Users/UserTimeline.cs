using System;

namespace UserCom.Model.Users
{
    public class UserTimeline
    {
        public int Id { get; set; }

        public DateTime Datetime { get; set; }

        public string Name { get; set; }

        public UserTimelineContent Content { get; set; }
    }
}