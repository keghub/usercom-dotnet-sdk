using System.Runtime.Serialization;

namespace UserCom.Model.Users
{
    public enum UserStatus
    {
        [EnumMember(Value = "visitor")]
        Visitor,
        [EnumMember(Value = "user")]
        User
    }
}