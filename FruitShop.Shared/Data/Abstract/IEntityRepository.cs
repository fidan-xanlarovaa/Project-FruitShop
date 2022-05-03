using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeproperties);
        Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null, params Expression<Func<T,object>>[] includeproperties);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null); 
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
