using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.EntityLayer.Concrete
{
    public class SubcomponentTypes
    {
        [Key]
        public int SubcomponentType { get; set; }

        public int StationId { get; set; }

        public decimal SubcomponentCost { get; set; }
    }
}
