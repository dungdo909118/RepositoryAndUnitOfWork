using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OM.Business.Models;
using OM.Business.Order;
using OM.Business.Product;
using OM.Core.CustomeErrors;

namespace OM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderBo _orderBo;
        private readonly ILogger<OrderController> _logger;
        public OrderController(IOrderBo orderBo, ILogger<OrderController> logger)
        {
            _orderBo = orderBo;
            _logger = logger;   
        }

        [HttpGet("Get", Name = "Order")]
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            try
            {
                var products = await _orderBo.GetAll(pageIndex, pageSize);

                if(products == null) {
                    return Ok(new DataApiResponse<IEnumerable<OrderModel>>() { Success = true, Message = "Data not found" });
                }
                return Ok(new DataApiResponse<IEnumerable<OrderModel>>() { Data = products, Success = true, Message =""});
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw new Exception();
            }
        }

        [HttpPost("Post", Name = "OrderAdd")]
        public async Task<IActionResult> Post([FromBody]OrderModel model)
        {
            try
            {
                if (model == null) return NotFound();
                var products = await _orderBo.Create(model);
                return Ok(new DataApiResponse<object>() { Data = products, Success = true, Message = "" }); ;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw new CustomeNotFoundException(ex.Message);
            }
        }
    }
}
