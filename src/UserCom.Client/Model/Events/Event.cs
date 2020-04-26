using System;
using System.Collections.Generic;

namespace UserCom.Model.Events
{
    public class Event
    {
        public int Id { get; set; }

        public int Client { get; set; }

        public DateTime Timestamp { get; set; }

        public IReadOnlyList<(string name, string value)> Items { get; set; }
    }
}