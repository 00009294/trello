using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Domain.Persistence.Repositories
{
    public class EfBaseRepository<TEntity, TContext> : IAsyncRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        private readonly TContext _context;

        public EfBaseRepository(TContext context)
        {
            _context = context;
        }
        public async Task<IList<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            int? takeOnly = null,
            bool enableTracking = false,
            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (orderBy != null)
                queryable = orderBy(queryable);
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (takeOnly.HasValue)
                queryable = queryable.Take(takeOnly.Value);
            return await queryable.ToListAsync(cancellationToken);
        }

        public Task<TEntity?> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool enableTracking = false,
            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            return queryable.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public IQueryable<TEntity> Query()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> QueryAsNoTracking()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<bool> AllAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await Query().AllAsync(predicate, cancellationToken);
        }

        public async Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await Query().AnyAsync(predicate, cancellationToken);
        }

        public async Task<TEntity> AddAsync(
            TEntity entity,
            CancellationToken cancellationToken)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(
            IEnumerable<TEntity> entities,
            CancellationToken cancellationToken)
        {
            await _context.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> DeleteAsync(
            TEntity entity,
            CancellationToken cancellationToken)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> DeleteRangeAsync(
            IEnumerable<TEntity> entities,
            CancellationToken cancellationToken)
        {
            _context.RemoveRange(entities);
            await _context.SaveChangesAsync(cancellationToken);
            return entities;
        }

        public async Task<TEntity> UpdateAsync(
            TEntity entity,
            CancellationToken cancellationToken)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateRangeAsync(
            IEnumerable<TEntity> entities,
            CancellationToken cancellationToken)
        {
            _context.UpdateRange(entities);
            await _context.SaveChangesAsync(cancellationToken);
            return entities;
        }
    }
}
