namespace Configuration.Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int Id);
    Task CreateAsync(T entity);
    Task<T> CreateAsyncwithEntity(T entity);
    Task<T> UpdateAsyncwithEntity(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int Id);
}