using BoschBootcamp.DTOLayer.Concrete.DTOs.SectionDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class SectionValidator : AbstractValidator<SectionDTO>
    {
        public SectionValidator() { 
        
            RuleFor(x => x.SectionID).NotEmpty();
            RuleFor(x => x.SectionName).NotEmpty().Length(1,6);
            RuleFor(x => x.DepartmentID).NotEmpty();
            RuleFor(x => x.ModelNumber).NotEmpty();
        }
    }
}
