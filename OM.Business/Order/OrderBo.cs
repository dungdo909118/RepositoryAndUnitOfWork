using OM.Business.Models;
using OM.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Order
{
    public class OrderBo : IOrderBo
    {
        private IUnitOfWork _unitOfWork;
        public OrderBo(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Create(OrderModel order)
        {
            if (order != null)
            {
                using (var transaction = _unitOfWork.BeginTransactionAsync())
                {

                    // 1. Save order
                    var orderEntity = new OM.Data.Entities.Order()
                    {
                        CustomerId = order.CustomerId,
                        OrderDate = order.OrderDate,
                        Status = order.Status,
                        TotalAmount = order.TotalAmount
                    };
                    var orderResult = await _unitOfWork.Orders.InsertAsync(orderEntity);
                    await _unitOfWork.SaveChangesAsync();

                    if (order.Orderdetails == null || !order.Orderdetails.Any())
                    {
                        await _unitOfWork.RollbackAsync();
                        return 0;
                    }

                    //2. save order detail
                    var orderDetails = new List<OM.Data.Entities.Orderdetail>();
                    foreach (var item in order.Orderdetails)
                    {
                        var orderDetailEntity = new OM.Data.Entities.Orderdetail()
                        {
                            OrderDetailId = item.OrderDetailId,
                            OrderId = orderResult.OrderId,
                            ProductId = item.ProductId,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice
                        };
                        orderDetails.Add(orderDetailEntity);
                    }

                    foreach (var item in orderDetails)
                    {
                        var orderDetailResult = await _unitOfWork.OrderDetail.InsertAsync(item);
                        await _unitOfWork.SaveChangesAsync();
                        throw new Exception("Data not valid");
                    }

                    await _unitOfWork.CommitAsync();
                }
            }
            return 1;
        }

        public async Task<IEnumerable<OrderModel>> GetAll(int pageIndex, int pageSize)
        {
            var products = await _unitOfWork.Orders.GetAsync(pageIndex, pageSize);
            if (products != null && products.Any())
            {
                return products.Select(x => new OrderModel(x)).ToList();
            }
            return null!;
        }
    }
}
