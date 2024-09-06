using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Models;
using OM.Business.Order;
using OM.Business.Product;

namespace OM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderBo _orderBo;
        public OrderController(IOrderBo orderBo)
        {
            _orderBo = orderBo;
        }

        [HttpGet("Get", Name = "Order")]
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            try
            {
                var products = await _orderBo.GetAll(pageIndex, pageSize);
                return Ok(products);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost("Add", Name = "OrderAdd")]
        public async Task<IActionResult> Add(OrderModel model)
        {
            try
            {
                if (model == null) return NotFound();
                var products = await _orderBo.Create(model);
                return Ok(products);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
