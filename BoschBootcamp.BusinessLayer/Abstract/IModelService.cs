using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IModelService
    {
    
        public bool AddModel(Models model);

        public bool UpdateModel(Models model);

        public bool DeleteModel(Models model);

        public List<Models> GetAllModels();

        public Models GetModelByID(string id);

        public Models GetModelByName(string name);

        public int GetReleatedInjectorCount(string id);

    }
}
