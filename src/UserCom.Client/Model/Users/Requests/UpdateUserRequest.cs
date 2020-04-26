namespace UserCom.Model.Users.Requests
{
    public class UpdateUserRequest : UpdateOrCreateUserRequest
    {
        public int Id { get; set; }
    }
}