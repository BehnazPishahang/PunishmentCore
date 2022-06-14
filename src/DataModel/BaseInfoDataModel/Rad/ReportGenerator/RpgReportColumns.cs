

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgReportColumnsBase : BaseInfoEntity<string>
    {

		[Column("AGGREGATETYPE")]
		public virtual Rad.CMS.Enumerations.RpgAggregateType? AggregateType { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("ISHAVEAGGREGATEFUNCTION")]
		public virtual Rad.CMS.Enumerations.YesNo? IsHaveAggregateFunction { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("ORDERNUMBER")]
		public virtual decimal? OrderNumber { get; set; }

		[Column("ORDERTYPE")]
		public virtual Rad.CMS.Enumerations.RpgOrderType? OrderType { get; set; }

		[ForeignKey("RPGREPORTVIEWSID")]
		public virtual Rad.ReportGenerator.RpgReportViews? TheRpgReportViews { get; set; }

		[ForeignKey("RPGVIEWATTRIBUTESID")]
		public virtual Rad.ReportGenerator.RpgViewAttributes? TheRpgViewAttributes { get; set; }

    }
    [Table("RPGREPORTCOLUMNS")]
    public partial class RpgReportColumns : RpgReportColumnsBase { }

    }


