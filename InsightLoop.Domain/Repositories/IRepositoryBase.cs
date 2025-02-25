namespace InsightLoop.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
