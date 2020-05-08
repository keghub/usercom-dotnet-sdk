using UserCom.Model.Attributes;
using UserCom.Model.CRM;
using UserCom.Model.Lists;
using UserCom.Model.Tags;
using UserCom.Model.Users;

namespace UserCom
{
    public interface IUserComClient
    {
        IUserComUsersClient Users { get; }

        IUserComCustomIdUsersClient CustomIdUsers { get; }

        IUserComCrmClient Crm { get; }

        IUserComCustomIdCrmClient CustomIdCrm { get; }

        IUserComListsClient Lists { get; }

        IUserComTagsClient Tags { get; }

        IUserComAttributesClient Attributes { get; }
    }
}