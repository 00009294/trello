using Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Domain.Persistence.Repositories
{
    public interface IAsyncRepository<TEntity> : IQuery<TEntity>
        where TEntity : BaseEntity
    {
        Task<TEntity?> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool enableTracking = false ,
            CancellationToken cancellationToken = default
        );

        Task<IList<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            int? takeOnly = null,
            bool enableTracking = false,
            CancellationToken cancellationToken = default
        );

        Task<TEntity> AddAsync(
            TEntity entity, 
            CancellationToken cancellationToken);
        Task<IEnumerable<TEntity>> AddRangeAsync(
            IEnumerable<TEntity> entities, 
            CancellationToken cancellationToken);
        Task<TEntity> UpdateAsync(
            TEntity entity, 
            CancellationToken cancellationToken);
        Task<IEnumerable<TEntity>> UpdateRangeAsync(
            IEnumerable<TEntity> entities, 
            CancellationToken cancellationToken);
        Task<TEntity> DeleteAsync(
            TEntity entity, 
            CancellationToken cancellationToken);
        Task<IEnumerable<TEntity>> DeleteRangeAsync(
            IEnumerable<TEntity> entities, 
            CancellationToken cancellationToken);
        Task<bool> AllAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default
        );
        Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default
        );
    }
}
