
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Interfaces
{

    /// <summary>
    /// NOTE: This is base interface for Reponsitory, it present for an object(a table in DB) so it should be only define COMMON functions
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync(int pageIndex, int pageSize);
        Task<T?> GetByIdAsync(int id);
        Task<bool> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> InsertAsync(T entity);
    }
}
