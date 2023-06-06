using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.Concrete;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BoschBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class ModelsController : Controller
    {
        private readonly IModelService modelService;

        public ModelsController(IModelService modelService) {

            this.modelService = modelService;
        }

        [HttpGet]
        public IActionResult GetModels()
        {
            var models = modelService.GetAllModels();
            if (models.Count() == 0)
            {
                return BadRequest("Failed"); //add Enum
            }
            else
            {
                return Ok(models);
            }
            
        }
        
        [HttpPost]
        public IActionResult AddModel(string number, string name)
        {
            var status = modelService.AddModel(new Models{ ModelNumber = number,ModelName=name });
            if (status)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest("Failed");
            }
        }

        [HttpDelete("delete{id}")]
        public IActionResult DeleteModel(string id)
        {
            var status = modelService.DeleteModel(new Models { ModelNumber = id});
            if (status)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest("Failed");
            }
        }

        [HttpPut]
        public IActionResult UpdateModel(string id,string name)
        {
            var status = modelService.UpdateModel(new Models { ModelName = name, ModelNumber = id });
            if (status)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest("Failed");
            }
        }

        
        [HttpGet("{id}")]
        public IActionResult GetModelById(string id)
        {
            var model = modelService.GetModelByID(id);
            return Ok(model);
        }

        [HttpGet("GetCount{id}")]
        public IActionResult GetModelCount(string id)
        {
            return Ok(modelService.GetReleatedInjectorCount(id));
        }

    }
}
