using InsightLoop.Domain.Repositories;
using InsightLoop.Domain.Entities;
using InsightLoop.Infra.Data;

namespace InsightLoop.Infra.Repositories
{
    public class FeedBackOwnerRepository : IFeedBackOwnerRepository
    {
        private readonly ApplicationDbContext _context;
        public FeedBackOwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }   
        public void Add(FeedBackOwner entity)
        {
            _context.FeedBackOwners.Add(entity);
        }

        public void Delete(FeedBackOwner entity)
        {
            _context.FeedBackOwners.Remove(entity);
        }

        public IEnumerable<FeedBackOwner> GetAll()
        {
            return _context.FeedBackOwners.ToList();
        }

        public FeedBackOwner? GetByIdAsync(Guid id)
        {
            return _context.FeedBackOwners.Find(id);
        }

        public void Update(FeedBackOwner entity)
        {
            _context.Update(entity);
        }
    }
}
