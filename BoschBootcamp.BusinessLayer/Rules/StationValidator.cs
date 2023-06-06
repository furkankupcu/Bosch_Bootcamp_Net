using BoschBootcamp.DTOLayer.Concrete.DTOs.StationDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class StationValidator : AbstractValidator<StationDTO>
    {
        public StationValidator() {
            RuleFor(x => x.StationID).NotEmpty();
        }
    }
}
