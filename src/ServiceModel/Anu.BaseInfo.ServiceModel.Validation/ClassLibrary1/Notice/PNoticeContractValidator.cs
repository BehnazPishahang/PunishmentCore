using FluentValidation;

namespace Anu.PunishmentOrg.ServiceModel.Validation.Notice
{
    public class PNoticeContractValidator : PunishmentOrgServiceModelValidator<ServiceModel.Notice.PNoticeContract>
    {
        public PNoticeContractValidator()
        {
            RuleFor(x => x.AgentName).NotEmpty().WithMessage("Please specify a AgentName");
            RuleFor(x => x.DeliverName).NotEmpty().WithMessage("Please specify a DeliverName");
        }
    }
}