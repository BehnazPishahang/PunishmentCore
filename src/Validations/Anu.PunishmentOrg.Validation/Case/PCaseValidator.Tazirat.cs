using FluentValidation;

namespace Anu.PunishmentOrg.Validation.Case
{
    public partial class PCaseValidator
    {
        public PCaseValidator()
        {
            this.RuleFor(x => x.ArchiveNo).Length(0, 10).When(x => x.Id != null);
            this.RuleFor(x => x.ArchiveNo).Length(2, 5);

        }
    }
}