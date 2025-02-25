using InsightLoop.Domain.Entities;

namespace InsightLoop.Domain.Repositories
{
    interface IFeedBackRepository : IRepositoryBase<Feedback>
    {
        IEnumerable<Feedback> GetByFeedBackOwnerId(Guid feedBackOwnerId);
    }
}
