

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class GNewspaperUnitBase : BaseInfoEntity<string>
    {

		[ForeignKey("GNEWSPAPERID")]
		public virtual Rad.BaseInfo.Types.GNewspaper? TheGNewspaper { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GNEWSPAPERUNIT")]
    public partial class GNewspaperUnit : GNewspaperUnitBase { }

    }


