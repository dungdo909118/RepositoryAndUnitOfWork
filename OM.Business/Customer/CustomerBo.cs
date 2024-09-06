using AutoMapper;
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
        private readonly IMapper _mapper;
        public CustomerBo(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerModel>> GetAll(int pageIndex, int pageSize)
        {
            var customers = await _unitOfWork.Customers.GetAsync(pageIndex, pageSize);
            if (customers != null && customers.Any())
            {
                return _mapper.Map<IEnumerable<CustomerModel>>(customers);
            }
            return null!;
        }
    }
}
