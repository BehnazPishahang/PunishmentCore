

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgReportBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ISUSERSELECTQUERY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsUserSelectQuery { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("SELECTCOMMAND")]
		public virtual string? SelectCommand { get; set; }

		[InverseProperty("TheRpgReport")]
		public virtual List<Rad.ReportGenerator.RpgReportViews>? TheRpgReportViewsList { get; set; }

		[InverseProperty("TheRpgReport")]
		public virtual List<Rad.ReportGenerator.RpgWhereClause>? TheRpgWhereClauseList { get; set; }

    }
    [Table("RPGREPORT")]
    public partial class RpgReport : RpgReportBase { }

    }


