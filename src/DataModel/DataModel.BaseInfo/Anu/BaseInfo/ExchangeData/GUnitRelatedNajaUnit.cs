

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.ExchangeData
{
    public abstract class GUnitRelatedNajaUnitBase : BaseInfoEntity<string>
    {

		[ForeignKey("NAJAUNITID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GUNITRELATEDNAJAUNIT")]
    public partial class GUnitRelatedNajaUnit : GUnitRelatedNajaUnitBase { }

    }


