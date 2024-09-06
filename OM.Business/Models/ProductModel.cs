using System;
using System.Collections.Generic;

namespace OM.Business.Models;

public class ProductModel
{
    public ProductModel(OM.Data.Entities.Product entity)
    {
          this.ProductId = entity.ProductId;
          this.ProductName = entity.ProductName;
          this.Price = entity.Price;
          this.StockQuantity = entity.StockQuantity;
          this.CreatedAt = entity.CreatedAt;
    }
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }
    public string PriceFormat { get {
            if(Price <= 0)  return "0";
            return Price.ToString("$###,#");
        } }

    public int StockQuantity { get; set; }

    public DateTime? CreatedAt { get; set; }
}
