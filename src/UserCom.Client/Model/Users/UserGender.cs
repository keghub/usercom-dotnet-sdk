using System.Runtime.Serialization;

namespace UserCom.Model.Users
{
    public enum UserGender
    {
        [EnumMember(Value = "unknown")]
        Unknown = 1,
        [EnumMember(Value = "male")]
        Male = 2,
        [EnumMember(Value = "female")]
        Female = 3
    }
}