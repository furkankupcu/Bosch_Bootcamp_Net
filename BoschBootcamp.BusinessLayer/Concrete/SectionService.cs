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
    public class SectionService : ISectionService
    {
        private readonly BBContext bBContext;

        public SectionService(BBContext bBContext) {
            
            this.bBContext = bBContext;
        }

        public bool AddSection(Section setion)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSection(Section setion)
        {
            throw new NotImplementedException();
        }

        public List<Section> GetAllSections()
        {
            return bBContext.BB_Section.ToList();
        }

        public Section GetSectionById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetSectionCount()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSection(Section setion)
        {
            throw new NotImplementedException();
        }
    }
}
