using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.InjectorDTOs
{
    public class InjectorDTO
    {
        public int InjectorID { get; set; }

        public char ModelNumber { get; set; }

        public decimal InjectorPrice { get; set; }

        public string? InjectorStatus { get; set; }

        public int OrderID { get; set; }
    }
}
