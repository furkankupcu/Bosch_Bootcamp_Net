using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.SectionDTOs
{
    public class SectionDTO
    {
        public int SectionID { get; set; }

        public string? SectionName { get; set; }

        public int DepartmentID { get; set; }

        public int ModelNumber { get; set; }
    }
}
