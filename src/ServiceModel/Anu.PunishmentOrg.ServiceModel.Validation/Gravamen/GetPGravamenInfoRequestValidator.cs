using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility.Extensions;
using FluentValidation;
using System;

namespace Anu.PunishmentOrg.ServiceModel.Validation.Gravamen
{
    public class GetPGravamenInfoRequestValidator : PunishmentOrgServiceModelValidator<GetPGravamenInfoRequest>
    {
        public GetPGravamenInfoRequestValidator()
        {
            this.RuleFor(x => x.TheGetPGravamenInfoContract!.FollowUpNo)
                .Cascade(CascadeMode.StopOnFirstFailure) //بدلیل اینکه هنگام اولین خطا دیگر ادامه ندهیم
                .NotNull()
                .WithMessage("شماره پیگیری معتبر نمی باشد.")
                .NotEmpty()
                .WithMessage("شماره پیگیری معتبر نمی باشد.")
                .Must(x => x.IsDigit())
                .WithMessage("شماره پیگیری می بایست عدد باشد.");
        }
    }
}