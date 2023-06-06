using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.EntityLayer.Concrete
{
    public class Models
    {
        [Key]
        public string? ModelNumber { get; set; }

        public string? ModelName { get; set; }
    }
}
