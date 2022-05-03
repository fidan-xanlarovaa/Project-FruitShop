using FruitShop.Shared.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Shared.Data.Concrete
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {

        #region fields

        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbset;

        #endregion

        #region ctor

        public EfRepositoryBase(DbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }


        #endregion

        #region implementation of interface

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return  await _dbset.AnyAsync(predicate);            
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate is null)
            {
                return await _dbset.CountAsync();

            }
            return await _dbset.CountAsync(predicate);
        }

       
        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            await Task.Run(()=> { _dbset.Remove(entity); });
            return entity;
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbset;

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties is not null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.ToListAsync();
        }

        

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbset;

            if(predicate is not null)
            {
                query = query.Where(predicate);
            }

            if(includeProperties is not null)
            {
                foreach (var incudeProperty in includeProperties)
                {
                    query=query.Include(incudeProperty);
                }
            }

            return await query.SingleOrDefaultAsync();
            
        }


        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(()=> { _dbset.Update(entity); });

            return entity;
        }

        #endregion

    }
}
