using BoschBootcamp.DTOLayer.Concrete.DTOs.StationProcessDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class StationProcessValidator : AbstractValidator<StationProcessDTO>
    {
        public StationProcessValidator() {

            RuleFor(x => x.StationID).NotEmpty().WithMessage("InjectorId cannot be empty.");
            RuleFor(x => x.InjectorID).NotEmpty();
            RuleFor(x => x.SubcomponentID).NotEmpty() ;
            RuleFor(x => x.ProcessTime).GreaterThanOrEqualTo(x => x.ProcessTime);
            RuleFor(x => x.ProcessStatus).NotEmpty().Length(3,10);
        }
    }
}
