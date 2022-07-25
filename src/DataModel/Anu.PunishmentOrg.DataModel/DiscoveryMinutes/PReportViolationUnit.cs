

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PReportViolationUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PREPORTVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

    }

    [Table("PREPORTVIOLATIONUNIT")]
    public partial class PReportViolationUnit : PReportViolationUnitBase
    {
    }
}