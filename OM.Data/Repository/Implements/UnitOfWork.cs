
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using OM.Data.DBContext;
using OM.Data.Entities;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OMDBContext _dbContext;
        private IDbContextTransaction _dbTransaction;
        public IProductRepository Products { get; private set; }
        public ICustomerRepository Customers { private set; get; }
        public IOrderRepository Orders { private set; get; }
        public IOrderDetailRepository OrderDetail { private set; get; }

        public UnitOfWork(OMDBContext dbContext)
        {
            _dbContext = dbContext;
            Products = new ProductRepository(dbContext);
            Customers = new CustomerRepository(dbContext);
            Orders = new OrderRepository(dbContext);
            OrderDetail = new OrderDetailRepository(dbContext);
        }
        public async Task BeginTransactionAsync()
        {
            _dbTransaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                if (_dbTransaction != null)
                {
                    await _dbTransaction.CommitAsync();
                }
            }
            catch (Exception)
            {
                await _dbTransaction.RollbackAsync();
                throw;
            }
            finally
            {
                await _dbTransaction.DisposeAsync();
                _dbTransaction = null!;
            }
        }

        public async Task RollbackAsync()
        {
           await _dbTransaction.RollbackAsync();
           await _dbTransaction.DisposeAsync();
           _dbTransaction = null!;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
