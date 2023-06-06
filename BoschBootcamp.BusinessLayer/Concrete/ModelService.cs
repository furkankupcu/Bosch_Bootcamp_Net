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
    public class ModelService : IModelService
    {
        private readonly BBContext bbContext;

        public ModelService(BBContext bbContext) {
            this.bbContext = bbContext;
        }

        public bool AddModel(Models model)
        {
            var result = bbContext.BB_Models.Any(b => b.ModelNumber ==  model.ModelNumber);
            if (!result)
            {
                try
                {
                    bbContext.BB_Models.Add(model);
                    bbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteModel(Models model)
        {
            var result = bbContext.BB_Models.Any(b => b.ModelNumber == model.ModelNumber);
            if (result)
            {
                try
                {
                    bbContext.BB_Models.Remove(model);
                    bbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateModel(Models model)
        {
            var result = bbContext.BB_Models.Any(b => b.ModelNumber == model.ModelNumber);
            if (result)
            {
                try
                {
                    bbContext.Update(model);
                    bbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Models> GetAllModels()
        {
            return bbContext.BB_Models.ToList();
        }

        public Models GetModelByID(string id)
        {
            return bbContext.BB_Models.Where(X => X.ModelNumber == id).FirstOrDefault();
            
        }

        public Models GetModelByName(string name)
        {
            return bbContext.BB_Models.Where(X => X.ModelName == name).FirstOrDefault();
        }

        public int GetReleatedInjectorCount(string id)
        {
            return bbContext.BB_Injector.Where(X => X.ModelNumber == id).Count();
        }

    }
}
