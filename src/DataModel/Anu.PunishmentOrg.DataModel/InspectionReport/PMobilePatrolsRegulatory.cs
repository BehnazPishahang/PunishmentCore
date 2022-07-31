

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsRegulatoryBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PMOBILEPATROLSID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrols? ThePMobilePatrols { get; set; }

    }

    [Table("PMOBILEPATROLSREGULATORY")]
    public partial class PMobilePatrolsRegulatory : PMobilePatrolsRegulatoryBase
    {
    }
    }