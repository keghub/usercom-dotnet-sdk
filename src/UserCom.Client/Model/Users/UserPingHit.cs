using System;

namespace UserCom.Model.Users
{
    public class UserPingHit
    {
        public int Id { get; set; }

        public int Client { get; set; }

        public string IpAddress { get; set; }

        public string UserAgent { get; set; }

        public string BrowserFamily { get; set; }

        public string BrowserVersion { get; set; }

        public string OsType { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Url { get; set; }

        public string Referer { get; set; }

        public DateTime Timestamp { get; set; }

        public string ExtraData { get; set; }

        public string Timezone { get; set; }

        public string Resolution { get; set; }
    }
}