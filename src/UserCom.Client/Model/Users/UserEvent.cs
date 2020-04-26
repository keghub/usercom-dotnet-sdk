using UserCom.Model.Events;

namespace UserCom.Model.Users
{
    public class UserEvent : Event
    {
        public string Event { get; set; }

        public int EventId { get; set; }
    }
}