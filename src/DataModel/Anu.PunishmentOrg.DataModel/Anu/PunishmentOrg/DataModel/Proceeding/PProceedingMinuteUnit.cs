

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PProceedingMinuteUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PPROCEEDINGMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinute? ThePProceedingMinute { get; set; }

    }

    [Table("PPROCEEDINGMINUTEUNIT")]
    public partial class PProceedingMinuteUnit : PProceedingMinuteUnitBase
    {
    }
}