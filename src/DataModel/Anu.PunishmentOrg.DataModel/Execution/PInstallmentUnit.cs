

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PInstallmentUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PINSTALLMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PInstallment? ThePInstallment { get; set; }

    }

    [Table("PINSTALLMENTUNIT")]
    public partial class PInstallmentUnit : PInstallmentUnitBase
    {
    }
}