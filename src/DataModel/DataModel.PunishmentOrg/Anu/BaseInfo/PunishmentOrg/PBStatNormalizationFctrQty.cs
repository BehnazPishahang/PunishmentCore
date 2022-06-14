

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBStatNormalizationFctrQtyBase : PunishmentOrgEntity<string>
    {

		[Column("QUANTITY")]
		public virtual long? Quantity { get; set; }

		[Column("REFRESHDATETIME")]
		public virtual string? RefreshDateTime { get; set; }

		[ForeignKey("PBSTATNORMALIZATIONFACTORID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBStatNormalizationFactor? ThePBStatNormalizationFactor { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBSTATNORMALIZATIONFCTRQTY")]
    public partial class PBStatNormalizationFctrQty : PBStatNormalizationFctrQtyBase { }

    }


