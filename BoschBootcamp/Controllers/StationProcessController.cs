using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class StationProcessController : Controller
    {
        private readonly IStationProcessService stationProcessService;

        public StationProcessController(IStationProcessService stationProcessService)
        {
            this.stationProcessService = stationProcessService;
        }

        [HttpGet]
        public IActionResult GetStationProcesses() {
        
            return Ok(stationProcessService.GetStationProcesses());
        }
    }
}
