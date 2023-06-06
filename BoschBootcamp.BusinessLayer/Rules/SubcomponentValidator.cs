using BoschBootcamp.DTOLayer.Concrete.DTOs.SubcomponentDTOs;
using BoschBootcamp.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class SubcomponentValidator : AbstractValidator<SubcomponentDTO>
    {
        public SubcomponentValidator()
        {
            RuleFor(x => x.SubcomponentID).NotEmpty();
            RuleFor(x => x.SubcomponentCost).NotEmpty();
        }
    }
}
