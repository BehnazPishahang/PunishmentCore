

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBReportTitleBase : BaseInfoEntity<string>
    {

		[Column("APPLICANTFUNCTION")]
		public virtual Anu.Enumerations.ApplicantFunctionType? ApplicantFunction { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FRMBUDGETTYPE")]
		public virtual Anu.Enumerations.FrmBudgetType? FrmBudgetType { get; set; }

		[Column("SHORTNAME")]
		public virtual string? ShortName { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheRelatedReport")]
		public virtual List<Anu.BaseInfo.DynamicFormGenBaseInfo.JBReportRelateds>? TheMainFormList { get; set; }

		[InverseProperty("TheMainReport")]
		public virtual List<Anu.BaseInfo.DynamicFormGenBaseInfo.JBReportRelateds>? TheRelatedReportList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JBREPORTTITLE")]
    public partial class JBReportTitle : JBReportTitleBase { }

    }


