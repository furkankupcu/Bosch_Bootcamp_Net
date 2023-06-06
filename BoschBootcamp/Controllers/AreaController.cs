using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Concrete;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class AreaController : Controller
    {
        private readonly IAreaService areaService;

        public AreaController(IAreaService areaService)
        {
            this.areaService= areaService;
        }


        [HttpGet]
        public IActionResult GetAreas() {

            var areas = areaService.GetAllAreas();
            if(areas.Count() == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(areas);
            }
        }
        
        [HttpPost]
        public IActionResult AddArea(char areaId, string areaName) { 
        
            var status = areaService.AddArea(new Area { AreaId= areaId, AreaName = areaName });
            if (status)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        
        [HttpDelete("delete{id}")]
        public IActionResult DeleteArea(char areaId) {

            var status = areaService.DeleteArea(new Area { AreaId = areaId});
            if (status)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult UpdateArea(char areaId,string areaName)
        {
            var status = areaService.UpdateArea(new Area{ AreaId = areaId, AreaName = areaName });
            if (status)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        
    }
}
