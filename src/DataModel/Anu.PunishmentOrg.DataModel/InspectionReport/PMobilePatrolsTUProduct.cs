using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsTUProductBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBPRODUCTCURRENCYTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

        [ForeignKey("PMOBILEPATROLSTRADEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTradeUnit? ThePMobilePatrolsTradeUnit { get; set; }

        }

    [Table("PMOBILEPATROLSTUPRODUCT")]
    public partial class PMobilePatrolsTUProduct : PMobilePatrolsTUProductBase
    {
    }
    }