using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly BBContext bBContext;

        public DepartmentManager(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddDepartment(int deparmentId)
        {
            throw new NotImplementedException();
        }

        public bool AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllDepartments()
        {
           return bBContext.BB_Department.ToList();
        }

        public int GetDepartmentCount()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDepartment()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
