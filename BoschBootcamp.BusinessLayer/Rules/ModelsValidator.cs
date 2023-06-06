using BoschBootcamp.DTOLayer.Concrete.DTOs.ModelsDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    internal class ModelsValidator : AbstractValidator<ModelsDTO>
    {
        public ModelsValidator() {

            RuleFor(x => x.ModelNumber).NotEmpty();
            RuleFor(x => x.ModelName).NotEmpty().MaximumLength(10);

        }
    }
}
