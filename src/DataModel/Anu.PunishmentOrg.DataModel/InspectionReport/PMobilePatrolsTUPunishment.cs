

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsTUPunishmentBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBMOBILPUNISHMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBMobilPunishment? ThePBMobilPunishment { get; set; }

        [ForeignKey("PMOBILEPATROLSTRADEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTradeUnit? ThePMobilePatrolsTradeUnit { get; set; }

    }

    [Table("PMOBILEPATROLSTUPUNISHMENT")]
    public partial class PMobilePatrolsTUPunishment : PMobilePatrolsTUPunishmentBase
    {
    }
    }