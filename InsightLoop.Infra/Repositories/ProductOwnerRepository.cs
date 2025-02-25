using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using InsightLoop.Infra.Data;

namespace InsightLoop.Infra.Repositories
{
    public class ProductOwnerRepository : IProductOwnerRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductOwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(ProductOwner entity)
        {
            _context.ProductOwners.Add(entity);
        }

        public void Delete(ProductOwner entity)
        {
            _context.ProductOwners.Remove(entity);
        }

        public IEnumerable<ProductOwner> GetAll()
        {
            return _context.ProductOwners.ToList();
        }

        public ProductOwner? GetByIdAsync(Guid id)
        {
            return _context.ProductOwners.Find(id);
        }

        public void Update(ProductOwner entity)
        {
           _context.Update(entity);
        }
    }
}
