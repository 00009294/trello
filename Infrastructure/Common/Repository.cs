using Application.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Common;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _context;
    public Repository(DbContext context)
    {
        _context = context;
    }
    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        return entity;
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}