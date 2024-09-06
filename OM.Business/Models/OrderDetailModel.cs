using System;
using System.Collections.Generic;

namespace OM.Business.Models;

public partial class OrderDetailModel
{
    public OrderDetailModel()
    {
            
    }
    public OrderDetailModel(OM.Data.Entities.Orderdetail entity)
    {
        OrderDetailId = entity.OrderDetailId;
        OrderId = entity.OrderId;
        ProductId = entity.ProductId;
        Quantity = entity.Quantity;
        UnitPrice = entity.UnitPrice;
    }
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }
}
