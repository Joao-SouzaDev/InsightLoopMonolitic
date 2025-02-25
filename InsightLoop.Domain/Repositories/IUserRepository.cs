using InsightLoop.Domain.Entities;

namespace InsightLoop.Domain.Repositories
{
    public interface IUserRepository : IRepositoryBase<IUser>
    {
        IUser GetByEmailAsync(string email);
    }
}
