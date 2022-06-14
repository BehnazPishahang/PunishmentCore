

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgDisplayReportBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FARSIWHEREDESCRIPTION")]
		public virtual string? FarsiWhereDescription { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("SELECTCOMMAND")]
		public virtual string? SelectCommand { get; set; }

		[ForeignKey("RPGDISPLAYREPORTID")]
		public virtual List<Rad.ReportGenerator.RpgDisplayReportColumn>? TheRpgDisplayReportColumnList { get; set; }

		[ForeignKey("RPGDISPLAYREPORTID")]
		public virtual List<Rad.ReportGenerator.RpgDisplayReportWhere>? TheRpgDisplayReportWhereList { get; set; }

		[ForeignKey("RPGREPORTID")]
		public virtual Rad.ReportGenerator.RpgReport? TheRpgReport { get; set; }

    }
    [Table("RPGDISPLAYREPORT")]
    public partial class RpgDisplayReport : RpgDisplayReportBase { }

    }


