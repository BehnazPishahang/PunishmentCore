

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Expert
{
    public abstract class ExpertWorkUnitBase : BaseInfoEntity<string>
    {

		[ForeignKey("EXPERTMANID")]
		public virtual Anu.BaseInfo.Expert.ExpertMan? TheExpertMan { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("EXPERTWORKUNIT")]
    public partial class ExpertWorkUnit : ExpertWorkUnitBase { }

    }


