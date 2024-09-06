using OM.Business.Models;
using OM.Data.Entities;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.OrderDetail
{
    public class OrderDetailBo : IOrderDetailBo
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderDetailBo(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
