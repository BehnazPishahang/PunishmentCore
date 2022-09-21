using FluentValidation;
using Anu.PunishmentOrg.DataModel.Case;

namespace Anu.PunishmentOrg.Validation.Case
{
    public abstract class PCaseValidatorBase : PunishmentOrgValidator<PCase>
    {
        public PCaseValidatorBase()
        {
            //RuleFor(x => x.ArchiveNo).Length(0,10);
            //RuleFor(x => x.ArchiveNo).NotNull();
            //RuleFor(x => x.CaseArchiveState).NotNull();
            //RuleFor(x => x.CasePassword).NotNull();
            //RuleFor(x => x.CaseSendType).NotNull();
            //RuleFor(x => x.CaseTitle).NotNull();
            //RuleFor(x => x.CaseType).NotNull();
            //RuleFor(x => x.CreateCaseType).NotNull();
            //RuleFor(x => x.CreateDateTime).NotNull();
            //RuleFor(x => x.Guild).NotNull();
            //RuleFor(x => x.ImportanceDegree).NotNull();
            //RuleFor(x => x.No).NotNull();
            //RuleFor(x => x.SourceObjectId).NotNull();
            //RuleFor(x => x.SubNo).NotNull();
        }
    }

    public partial class PCaseValidator : PCaseValidatorBase
    {
    }
}
