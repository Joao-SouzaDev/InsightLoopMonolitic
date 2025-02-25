using InsightLoop.Domain.Entities;

namespace InsightLoop.Domain.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByProductOwnerId(Guid productOwnerId);
    }
}
