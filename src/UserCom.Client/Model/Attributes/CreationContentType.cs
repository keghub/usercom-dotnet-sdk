using System.Runtime.Serialization;

namespace UserCom.Model.Attributes
{
    public enum CreationContentType
    {
        [EnumMember(Value = "clientuser")]
        ClientUser,
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "deal")]
        Deal,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "ticket")]
        Ticket
    }
}
