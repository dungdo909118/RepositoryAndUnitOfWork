using OM.Business.Customer;
using OM.Business.Models;
using OM.Data.Entities;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Customer
{
    public class CustomerBo : ICustomerBo
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerBo(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CustomerModel>> GetAll(int pageIndex, int pageSize)
        {
            var customers = await _unitOfWork.Customers.GetAsync(pageIndex, pageSize);
            if (customers != null && customers.Any())
            {
                return customers.Select(x => new CustomerModel(x)).ToList();
            }
            return null!;
        }
    }
}
