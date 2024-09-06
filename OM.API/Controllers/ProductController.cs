using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Models;
using OM.Business.Product;
using OM.Core.CustomeErrors;

namespace OM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBo _productBo;
        public ProductController(IProductBo productBo)
        {
            _productBo = productBo;
        }

        [HttpGet("Get", Name = "Product")]
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            try
            {
                var products = await _productBo.GetAll(pageIndex, pageSize);
                return Ok(new DataApiResponse<IEnumerable<ProductModel>>() { Data = products, Success = true, Message = "" });
            }
            catch (Exception)
            {
                throw new CustomeNotFoundException("Data not found.");
            }
        }
    }
}
