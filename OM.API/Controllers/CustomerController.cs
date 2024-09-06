using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Customer;
using OM.Business.Models;
using OM.Core.CustomeErrors;

namespace OM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBo _customerBo;
        public CustomerController(ICustomerBo customerBo)
        {
            _customerBo = customerBo;
        }

        [HttpGet("Get",Name = "Customer")]
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            try
            {
                var products = await _customerBo.GetAll(pageIndex, pageSize);
                return Ok(new DataApiResponse<IEnumerable<CustomerModel>>() { Data = products, Success = true, Message = "" });
            }
            catch (Exception)
            {
                throw new CustomeNotFoundException("Data not found.");
            }
        }
    }
}
