

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBUnitRelatedUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("MAINUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheMainUnit { get; set; }

		[ForeignKey("RELATEDUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheRelatedUnit { get; set; }

    }
    [Table("PBUNITRELATEDUNIT")]
    public partial class PBUnitRelatedUnit : PBUnitRelatedUnitBase { }

    }


