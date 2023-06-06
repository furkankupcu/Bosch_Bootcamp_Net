using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class SubcomponentController : Controller
    {
        private readonly ISubcomponentService subcomponentService;

        public SubcomponentController(ISubcomponentService subcomponentService)
        {
            this.subcomponentService = subcomponentService;
        }


        [HttpGet]
        public IActionResult Getsubcomponens() {
        
            return Ok(subcomponentService.GetAllSubcomponents());
        }
    }
}
