using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.EntityLayer.Concrete
{
    [Keyless]
    public class OrderDetail
    {
        public int OrderID { get; set; }

        public string? ModelNumber { get; set; }

        public int OrderQuantity { get; set; }
    }
}
