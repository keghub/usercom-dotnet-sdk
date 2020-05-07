using System.Runtime.Serialization;

namespace UserCom.Model.Attributes
{
    public enum ValueType
    {
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "fixed")]
        Fixed,
        [EnumMember(Value = "float")]
        Float
    }
}