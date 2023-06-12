using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
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

        [HttpPost]
        public IActionResult AddStationProcesses(int stationId,int InjectorId,int subcomponentId,int processStatus) {

            DateTime date= DateTime.Now;
            BusinessResponse status = stationProcessService.AddStationProcess(
                new StationProcess { StationID = stationId, InjectorID= InjectorId, SubcomponentID= subcomponentId,ProcessTime=date,ProcessStatus= processStatus});

            return status.Success ? Ok(status) : BadRequest(status);

        }
    }
}
