using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Singularity_Test.Repo
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        void Delete(object id);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<TEntity> GetByIDAsync(object id);
        TEntity GetByID(object id);

        void Insert(TEntity entity);
        void InsertRange(List<TEntity> entity);
        void Update(TEntity entityToUpdate);
        void UpdateRange(List<TEntity> entityToUpdate);
        Task<int?> GetMaxIDAsync(Expression<Func<TEntity, int?>> filter);
        int? GetMaxID(Expression<Func<TEntity, int?>> filter);
        void DeleteWhere(Expression<Func<TEntity, bool>> filter = null);
        void DeleteRange(List<TEntity> entityToDelete);
    }
}
