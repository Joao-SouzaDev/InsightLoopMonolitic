using InsightLoop.Domain.Entities;

namespace InsightLoop.Domain.Repositories
{
    public interface IFeedBackRepository : IRepositoryBase<Feedback>
    {
        IEnumerable<Feedback> GetByFeedBackOwnerId(Guid feedBackOwnerId);
    }
}
