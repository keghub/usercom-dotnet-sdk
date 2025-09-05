using System.Runtime.Serialization;

namespace UserCom.Model.Attributes
{
    public enum ValueType
    {
        [EnumMember(Value = "boolean")]
        Boolean = 1,
        [EnumMember(Value = "integer")]
        Integer = 2,
        [EnumMember(Value = "date")]
        Date = 3,
        [EnumMember(Value = "string")]
        String = 4,
        [EnumMember(Value = "datetime")]
        Datetime = 5,
        [EnumMember(Value = "fixed")]
        Fixed = 6,
        [EnumMember(Value = "float")]
        Float = 7
    }
}