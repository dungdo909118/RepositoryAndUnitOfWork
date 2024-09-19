using OM.Data.DBContext;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Implements
{
    public class OrderDetailRepository : Repository<OM.Data.Entities.Orderdetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(OMDBContext oMDBContext) : base(oMDBContext)
        {

        }

        //TODO: you can add more method for only OrderDetailRepository here
    }
}
