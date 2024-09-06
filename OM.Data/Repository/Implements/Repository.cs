
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OM.Data.DBContext;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Implements
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly OMDBContext _oMDBContext;
        public Repository(OMDBContext oMDBContext)
        {
            _dbSet = oMDBContext.Set<T>();
            _oMDBContext = oMDBContext;
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _oMDBContext.SaveChangesAsync();
            return true;
        }

        public virtual async Task<IEnumerable<T>> GetAsync(int pageIndex, int pageSize)
        {
            return await _dbSet.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await _oMDBContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _oMDBContext.Entry(entity).State = EntityState.Modified;
            await _oMDBContext.SaveChangesAsync();
            return entity;
        }
    }
}
