using System.Runtime.Serialization;

namespace UserCom.Model.Users
{
    public enum UserStatus
    {
        [EnumMember(Value = "visitor")]
        Visitor = 1,
        [EnumMember(Value = "user")]
        User = 2
    }
}