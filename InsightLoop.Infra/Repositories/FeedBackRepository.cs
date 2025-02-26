using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using InsightLoop.Infra.Data;

namespace InsightLoop.Infra.Repositories
{
    public class FeedBackRepository : IFeedBackRepository
    {
        private readonly ApplicationDbContext _context;
        public FeedBackRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Feedback entity)
        {
            _context.Feedbacks.Add(entity);
        }

        public void Delete(Feedback entity)
        {
            _context.Feedbacks.Remove(entity);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _context.Feedbacks.ToList();
        }

        public Feedback? GetByIdAsync(Guid id)
        {
            return _context.Feedbacks.Find(id);
        }

        public void Update(Feedback entity)
        {
            _context.Feedbacks.Update(entity);
        }
    }
}
