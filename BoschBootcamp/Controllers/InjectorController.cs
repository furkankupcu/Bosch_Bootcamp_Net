using BoschBootcamp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class InjectorController : Controller
    {
        private readonly IInjectorService injectorService;

        public InjectorController(IInjectorService injectorService) { 
            this.injectorService = injectorService;
        }

        [HttpGet]
        public IActionResult GetAllInjectors() {

            return Ok(injectorService.GetAllInjectors());
        }
    }
}
