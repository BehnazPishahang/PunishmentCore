

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgDisplayReportColumnBase : BaseInfoEntity<string>
    {

		[Column("DISPLAYORDERNUMBER")]
		public virtual decimal? DisplayOrderNumber { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("LENGTHCOLUMN")]
		public virtual decimal? LengthColumn { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("ORDERNUMBER")]
		public virtual decimal? OrderNumber { get; set; }

		[Column("ORDERTYPE")]
		public virtual Rad.CMS.Enumerations.RpgOrderType? OrderType { get; set; }

		[Column("POSX")]
		public virtual decimal? PosX { get; set; }

		[Column("POSY")]
		public virtual decimal? PosY { get; set; }

		[ForeignKey("RPGREPORTCOLUMNSID")]
		public virtual Rad.ReportGenerator.RpgReportColumns? TheRpgReportColumns { get; set; }

		[Column("WIDTHCOLUMN")]
		public virtual decimal? WidthColumn { get; set; }

    }
    [Table("RPGDISPLAYREPORTCOLUMN")]
    public partial class RpgDisplayReportColumn : RpgDisplayReportColumnBase { }

    }


