namespace InsightLoop.Domain.Entities
{
    public interface IUser
    {
        Guid Id { get; }
        string UserName { get; }
        string Email { get; }
        void SetUserName(string userName);
        void SetEmail(string email);
    }
}
