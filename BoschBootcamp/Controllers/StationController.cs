using BoschBootcamp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class StationController : Controller
    {

        private readonly IStationService stationService;

        public StationController(IStationService stationService)
        {
            this.stationService = stationService;
        }


        [HttpGet]
        public IActionResult GetStations()
        {
            return Ok(stationService.GetAllStations());
        }
    }
}
