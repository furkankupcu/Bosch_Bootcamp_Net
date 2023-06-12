using BoschBootcamp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class SubcomponentTypesController : Controller
    {
        private readonly ISubcomponentTypesService subcomponentTypesService;


        public SubcomponentTypesController(ISubcomponentTypesService subcomponentTypesService) {
            this.subcomponentTypesService = subcomponentTypesService;
        }

        [HttpGet]
        public IActionResult GetSubcomponentTypes()
        {
            return Ok(subcomponentTypesService.GetSubcomponentTypes());
        }

        [HttpGet("byStationId")]
        public IActionResult GetByStationID(int id)
        {
            return Ok(subcomponentTypesService.GetSubcomponentTypesByStationId(id));
        }
    }
}
