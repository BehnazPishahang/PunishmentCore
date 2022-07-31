

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBStatNormalizationFctrQtyBase : PunishmentOrgEntity<string>
    {

        [Column("QUANTITY")]
        public virtual long? Quantity { get; set; }

        [Unicode(false)]
        [Column("REFRESHDATETIME")]
        public virtual string? RefreshDateTime { get; set; }

        [ForeignKey("PBSTATNORMALIZATIONFACTORID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBStatNormalizationFactor? ThePBStatNormalizationFactor { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PBSTATNORMALIZATIONFCTRQTY")]
    public partial class PBStatNormalizationFctrQty : PBStatNormalizationFctrQtyBase
    {
    }
    }