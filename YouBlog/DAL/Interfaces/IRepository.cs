namespace YouBlog.DAL.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task Create(T item);
        void Update(T item);
        Task<bool> Delete(int id);
        Task Save(); 
    }
}
