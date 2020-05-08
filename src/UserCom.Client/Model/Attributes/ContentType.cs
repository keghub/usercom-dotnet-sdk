using System.Runtime.Serialization;

namespace UserCom.Model.Attributes
{
    public enum ContentType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "deal")]
        Deal,
        [EnumMember(Value = "product")]
        Product
    }
}