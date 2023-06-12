using Azure.Core;
using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors("AllowOrigin")]
        public IActionResult GetInjectors() {

            return Ok(injectorService.GetAllInjectors());
        }

        
        [HttpPost("addInjector")]
        [EnableCors("AllowOrigin")]
        public IActionResult AddInjector(string modelNumber, decimal price, string injectorStatus, int orderId)
        { 
            int index = injectorService.GetInjectorCount() + 1;
            BusinessResponse status = injectorService.AddInjector( new Injector {Injector_ID = index, ModelNumber = modelNumber,InjectorPrice=price, InjectorStatus = injectorStatus, OrderID = orderId });

            return status.Success ? Ok(status) : BadRequest(status);

        }

        [HttpPost("addMultipleInjector")]
        public IActionResult AddInjector(int count,string modelNumber, int orderId)
        {
            int index = injectorService.GetInjectorCount() + 1;
      
            for (int i = 0; i < count; i++)
            {
                BusinessResponse status = injectorService.AddInjector(new Injector { Injector_ID = index + i, ModelNumber = modelNumber, InjectorStatus="GOOD" ,OrderID = orderId });
                
                if(status.Success == false)
                {
                    return BadRequest(status);
                }
            }
            return Ok("Injectors added.");
        }

        [HttpDelete()]
        public IActionResult DeleteInjector(int id)
        {
            var status = injectorService.DeleteInjector(new Injector { Injector_ID = id });
            return status.Success ? Ok(status) : BadRequest(status);
        }

        [HttpPut("updateInjector")]
        public IActionResult UpdateInjectorPrice(int injectorId,decimal injectorPrice) {

            Injector currentInjector = injectorService.GetInjectorByID(injectorId);
            currentInjector.InjectorPrice = injectorPrice;

            var status = injectorService.UpdateInjector(currentInjector);
            return status.Success ? Ok(status) : BadRequest(status);
        }

        [HttpGet("ModelCount")]
        public IActionResult countInjectorModel()
        {
            return Ok(injectorService.getModelsCount());
        }
    }
}
