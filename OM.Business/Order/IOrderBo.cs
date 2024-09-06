
using OM.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Order
{
    public interface IOrderBo
    {
        Task<IEnumerable<OrderModel>> GetAll(int pageIndex, int pageSize);
        Task<int> Create(OrderModel order);
    }
}
