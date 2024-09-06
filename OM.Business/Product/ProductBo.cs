using OM.Business.Models;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Product
{
    public class ProductBo : IProductBo
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductBo(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<ProductModel>> GetAll(int pageIndex, int pageSize)
        {
            var products = await _unitOfWork.Products.GetAsync(pageIndex, pageSize);
            if (products != null && products.Any())
            {
                return products.Select(x => new ProductModel(x)).ToList();
            }
            return null!;
        }
    }
}
