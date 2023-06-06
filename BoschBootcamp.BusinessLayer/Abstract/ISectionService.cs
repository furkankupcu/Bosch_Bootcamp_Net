using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface ISectionService
    {
        public List<Section> GetAllSections();

        public bool AddSection(Section setion);

        public bool UpdateSection(Section setion);
        
        public bool DeleteSection(Section setion);

        public Section GetSectionById(int id);

        public int GetSectionCount();
    }
}
