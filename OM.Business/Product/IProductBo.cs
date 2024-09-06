
using OM.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Product
{
    public interface IProductBo
    {
        Task<IEnumerable<ProductModel>> GetAll(int pageIndex, int pageSize);
    }
}
