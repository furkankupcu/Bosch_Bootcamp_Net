using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BoschBootcamp.Controllers
{

    [ApiController]
    [Route("api/[controller]s")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService) { 
        
            this._departmentService= departmentService;
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            var departments = _departmentService.GetAllDepartments();
            if (departments.Count() == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(departments);
            }
        }
       
    }
}
