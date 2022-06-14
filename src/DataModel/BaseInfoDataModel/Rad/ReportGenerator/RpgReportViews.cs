

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgReportViewsBase : BaseInfoEntity<string>
    {

		[Column("ALIASFARSINAME")]
		public virtual string? AliasFarsiName { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("INPUTORDER")]
		public virtual decimal? InputOrder { get; set; }

		[InverseProperty("TheSecondView")]
		public virtual List<Rad.ReportGenerator.RpgReportViewsRelation>? TheFirstViewsList { get; set; }

		[ForeignKey("RPGREPORTID")]
		public virtual Rad.ReportGenerator.RpgReport? TheRpgReport { get; set; }

		[InverseProperty("TheRpgReportViews")]
		public virtual List<Rad.ReportGenerator.RpgReportColumns>? TheRpgReportColumnsList { get; set; }

		[ForeignKey("RPGVIEWSID")]
		public virtual Rad.ReportGenerator.RpgViews? TheRpgViews { get; set; }

		[InverseProperty("TheFirstView")]
		public virtual List<Rad.ReportGenerator.RpgReportViewsRelation>? TheSecondViewsList { get; set; }

    }
    [Table("RPGREPORTVIEWS")]
    public partial class RpgReportViews : RpgReportViewsBase { }

    }


