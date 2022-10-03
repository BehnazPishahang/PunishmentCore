using Anu.PunishmentOrg.ServiceModel.Gravamen;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.Validation.Gravamen
{
    public class GetPGravamenByIdRequestValidator : PunishmentOrgServiceModelValidator<GetPGravamenByIdRequest>
    {
        public GetPGravamenByIdRequestValidator()
        {
            RuleFor(x => x.ThePGravamenByIdContract).NotNull().WithMessage("شی گزارش مردمی نمی تواند خالی باشد.");
            RuleFor(x => x.ThePGravamenByIdContract.FollowUpNo).NotEmpty().WithMessage("شماره پیگیری نمی تواند خالی باشد.");
        }
    }
}