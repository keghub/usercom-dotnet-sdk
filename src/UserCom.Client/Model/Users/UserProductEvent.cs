using System;
using System.Collections.Generic;

namespace UserCom.Model.Users
{
    public class UserProductEvent
    {
        public int Id { get; set; }

        public int Client { get; set; }

        public DateTime Timestamp { get; set; }

        public string EventType { get; set; }

        public Dictionary<string, object> CustomData { get; set; }
    }
}