

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBUnitRelatedUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("MAINUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheMainUnit { get; set; }

        [ForeignKey("RELATEDUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheRelatedUnit { get; set; }

    }

    [Table("PBUNITRELATEDUNIT")]
    public partial class PBUnitRelatedUnit : PBUnitRelatedUnitBase
    {
    }
    }