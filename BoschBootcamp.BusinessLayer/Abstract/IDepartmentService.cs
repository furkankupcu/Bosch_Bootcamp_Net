using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IDepartmentService
    {
        public bool AddDepartment(Department department);

        public bool DeleteDepartment(Department department);

        public bool UpdateDepartment(Department department);

        public List<Department> GetAllDepartments();

        public int GetDepartmentCount();
    }
}
