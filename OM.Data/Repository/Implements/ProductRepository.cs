using OM.Data.DBContext;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Implements
{
    public class ProductRepository : Repository<OM.Data.Entities.Product>, IProductRepository
    {
        public ProductRepository(OMDBContext oMDBContext) : base(oMDBContext)
        {

        }

    }
}
