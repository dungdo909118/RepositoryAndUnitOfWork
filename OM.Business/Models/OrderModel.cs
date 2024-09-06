using System;
using System.Collections.Generic;

namespace OM.Business.Models;

public class OrderModel
{
    public OrderModel()
    {
            
    }
    public OrderModel(OM.Data.Entities.Order entity)
    {
        OrderId = entity.OrderId;
        CustomerId = entity.CustomerId;
        OrderDate = entity.OrderDate;
        Status = entity.Status;
        TotalAmount = entity.TotalAmount;
        Orderdetails = entity.Orderdetails.Select(x => new OrderDetailModel(x)).ToList();
    }
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Status { get; set; }

    public decimal? TotalAmount { get; set; }
    public ICollection<OrderDetailModel> Orderdetails { get; set; } = new List<OrderDetailModel>();
}
