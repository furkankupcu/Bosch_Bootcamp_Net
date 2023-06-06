using BoschBootcamp.DTOLayer.Concrete.DTOs.AreaDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class AreaValidator : AbstractValidator<AreaDTO>
    {
        public AreaValidator() { 
        
            RuleFor(x => x.AreaId).NotEmpty().WithMessage("Areaid cannot be empty.");
            RuleFor(x => x.AreaName).NotEmpty().MaximumLength(15);
        }
    }
}
