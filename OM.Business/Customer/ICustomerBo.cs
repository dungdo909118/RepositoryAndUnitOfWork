
using OM.Business.Models;
using OM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Customer
{
    public interface ICustomerBo
    {
        Task<IEnumerable<CustomerModel>> GetAll(int pageIndex, int pageSize);
    }
}
