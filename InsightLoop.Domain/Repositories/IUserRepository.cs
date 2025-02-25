using InsightLoop.Domain.Entities;

namespace InsightLoop.Domain.Repositories
{
    interface IUserRepository : IRepositoryBase<IUser>
    {
        IUser GetByEmail(string email);
    }
}
