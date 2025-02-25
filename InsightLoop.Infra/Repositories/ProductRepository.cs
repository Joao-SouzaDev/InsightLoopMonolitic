using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using InsightLoop.Infra.Data;

namespace InsightLoop.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product? GetByIdAsync(Guid id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<Product> GetByProductOwnerId(Guid productOwnerId)
        {
            return _context.Products.Where(p => p.ProductOwnerId == productOwnerId).ToList();
        }

        public void Update(Product entity)
        {
            _context.Products.Update(entity);
        }
    }
}
