using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility.Extensions;
using FluentValidation;

namespace Anu.PunishmentOrg.ServiceModel.Validation.Gravamen
{
    public class GetPGravamenInfoRequestValidator : PunishmentOrgServiceModelValidator<GetPGravamenInfoRequest>
    {
        public GetPGravamenInfoRequestValidator()
        {
            this.RuleFor(x => x.TheGetPGravamenInfoContract!.FollowUpNo)
                .Cascade(CascadeMode.StopOnFirstFailure) //بدلیل اینکه هنگام اولین خطا دیگر ادامه ندهیم
                .NotNull()
                .WithMessage(Resources.Common.Resources_ResultType.ResourceManager.GetString(GetPGravamenInfoResult
                    .PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required.ToString()))
                .WithErrorCode(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required.ToString())
                .Must(x => x!.IsDigit())
                .WithMessage(Resources.Common.Resources_ResultType.ResourceManager.GetString(GetPGravamenInfoResult
                    .PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required.ToString()))
                .WithErrorCode(GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required.ToString());
        }
    }
}