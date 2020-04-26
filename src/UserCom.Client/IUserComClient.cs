using UserCom.Model.Users;

namespace UserCom
{
    public interface IUserComClient
    {
        IUserComUsersClient Users { get; }
    }
}