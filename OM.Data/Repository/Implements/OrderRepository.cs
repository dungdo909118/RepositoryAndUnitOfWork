using Microsoft.EntityFrameworkCore;
using OM.Data.DBContext;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Implements
{
    public class OrderRepository : Repository<OM.Data.Entities.Order>, IOrderRepository
    {
        private readonly OMDBContext _oMDBContext;
        public OrderRepository(OMDBContext oMDBContext) : base(oMDBContext)
        {
            _oMDBContext = oMDBContext;
        }

        public override async Task<IEnumerable<OM.Data.Entities.Order>> GetAsync(int pageIndex, int pageSize)
        {
            return await _oMDBContext.Orders.Include(x => x.Orderdetails).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}
