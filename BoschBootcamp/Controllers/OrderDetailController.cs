using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            this.orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            var orderDetail = orderDetailService.GetOrderDetails();
            if (orderDetail.Count() == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(orderDetail);
            }

        }

    }
}
