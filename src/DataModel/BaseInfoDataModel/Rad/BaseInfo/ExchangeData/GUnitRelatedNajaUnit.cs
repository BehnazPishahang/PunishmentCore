

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.ExchangeData
{
    public abstract class GUnitRelatedNajaUnitBase : BaseInfoEntity<string>
    {

		[ForeignKey("NAJAUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GUNITRELATEDNAJAUNIT")]
    public partial class GUnitRelatedNajaUnit : GUnitRelatedNajaUnitBase { }

    }


