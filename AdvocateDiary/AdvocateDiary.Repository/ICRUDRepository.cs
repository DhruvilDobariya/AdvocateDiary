namespace AdvocateDiary.Repository
{
    public interface ICRUDRepository<T> where T : class
    {
        string Message { get; set; }
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task<bool> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int Id);
    }
}
