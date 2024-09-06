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
        public OrderRepository(OMDBContext oMDBContext) : base(oMDBContext)
        {

        }
    }
}
