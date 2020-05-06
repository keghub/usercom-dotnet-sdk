using System.Runtime.Serialization;

namespace UserCom.Model.Users
{
    public enum UserGender
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "female")]
        Female = 2,
        [EnumMember(Value = "male")]
        Male = 3
    }
}