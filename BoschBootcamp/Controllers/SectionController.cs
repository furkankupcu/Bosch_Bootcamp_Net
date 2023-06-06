using BoschBootcamp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class SectionController : Controller
    {
        private readonly ISectionService sectionService;

        public SectionController(ISectionService sectionService)
        {
            this.sectionService = sectionService;
        }

        [HttpGet]
        public IActionResult GetSections()
        {
            return Ok(sectionService.GetAllSections());
        }
    }
}
