using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface ISubcomponentService
    {
        public List<Subcomponent> GetAllSubcomponents();

        public bool AddSubcomponent(Subcomponent subcomponent);

        public bool UpdateSubcomponent(Subcomponent subcomponent);

        public bool DeleteSubcomponent(Subcomponent subcomponent);

        public Subcomponent GetSubcomponentById(int id);

        public int GetSubcomponentCount(int id);

        public List<int> GetNotAddedSubcomponents();
    }
}
