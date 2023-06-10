using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.BusinessRules;
using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Concrete
{
    public class ModelManager : IModelService, IDisposable
    {
        private readonly BBContext bbContext;
        private readonly ModelsBusinessRule _modelsBusinessRule;

        public ModelManager(BBContext bbContext, ModelsBusinessRule modelsBusinessRule) {
            this.bbContext = bbContext;
            this._modelsBusinessRule = modelsBusinessRule;
        }

        public BusinessResponse AddModel(Models model)
        {
            var result = _modelsBusinessRule.ModelIsExist(model.ModelNumber);
            if (!result)
            {
                try
                {
                    bbContext.BB_Models.Add(model);
                    bbContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Model added successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The model already exists." };
            }
        }

        public BusinessResponse DeleteModel(Models model)
        {
            var result = _modelsBusinessRule.ModelIsExist(model.ModelNumber);
            if (result)
            {
                try
                {
                    bbContext.BB_Models.Remove(model);
                    bbContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Model deleted successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message};
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The model not exists." };
            }
        }

        public BusinessResponse UpdateModel(Models model)
        {

            var result = _modelsBusinessRule.ModelIsExist(model.ModelNumber);
            if (result)
            {
                try
                {
                    bbContext.Update(model);
                    bbContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Model updated successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The model not exists." };
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

        public void Dispose()
        {
            ((IDisposable)bbContext).Dispose();
        }
    }
}
