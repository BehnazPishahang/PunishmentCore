

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart
{
    public abstract class GUnitImagesBase : BaseInfoEntity<string>
    {

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[ForeignKey("GUNITIMAGETYPEID")]
		public virtual Anu.BaseInfo.OrganizationChart.GUnitImageType? TheGUnitImageType { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GUNITIMAGES")]
    public partial class GUnitImages : GUnitImagesBase { }

    }


