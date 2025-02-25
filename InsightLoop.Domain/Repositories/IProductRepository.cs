using InsightLoop.Domain.Entities;

namespace InsightLoop.Domain.Repositories
{
    interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByProductOwnerId(Guid productOwnerId);
    }
}
