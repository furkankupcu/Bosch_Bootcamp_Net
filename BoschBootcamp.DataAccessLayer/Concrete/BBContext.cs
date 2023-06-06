using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using BoschBootcamp.EntityLayer.Concrete;

namespace BoschBootcamp.DataAccessLayer.Concrete
{
    public class BBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-62D526Q; database=Bosch_Bootcamp;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Area> BB_Area { get; set; }

        public DbSet<Department> BB_Department { get; set; }

        public DbSet<Injector> BB_Injector { get; set; }

        public DbSet<Models> BB_Models { get; set; }

        public DbSet<Order> BB_Order { get; set; }

        public DbSet<OrderDetail> BB_OrderDetail { get; set; }

        public DbSet<Section> BB_Section { get; set; }

        public DbSet<Station> BB_Station { get; set; }
        
        public DbSet<StationProcess> BB_StationProcess { get; set; }

        public DbSet<Subcomponent> BB_Subcomponent { get; set; }
    }

   
}
