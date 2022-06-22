

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableReportActivityBase : BaseInfoEntity<string>
    {

		[Column("ACCESSDATATYPE")]
		public virtual Anu.Enumerations.ReportAccessDataType? AccessDataType { get; set; }

		[Column("ACTIVITYORDER")]
		public virtual decimal? ActivityOrder { get; set; }

		[Column("ISACTIVE")]
		public virtual Anu.Enumerations.YesNo? IsActive { get; set; }

		[Column("ISAFTERFINALSTATE")]
		public virtual Anu.Enumerations.YesNo? IsAfterFinalState { get; set; }

		[Column("ISFINALLYACTIVITY")]
		public virtual Anu.Enumerations.YesNo? IsFinallyActivity { get; set; }

		[Column("ISMAINACTIVITY")]
		public virtual Anu.Enumerations.YesNo? IsMainActivity { get; set; }

		[Column("ISRETURNAFTERFINALSTATE")]
		public virtual Anu.Enumerations.YesNo? IsReturnAfterFinalState { get; set; }

		[Column("ISSTARTERACTIVITY")]
		public virtual Anu.Enumerations.YesNo? IsStarterActivity { get; set; }

		[Column("REVERSIBLE")]
		public virtual Anu.Enumerations.YesNo? Reversible { get; set; }

		[InverseProperty("TheActivity")]
		public virtual List<Anu.DynamicFormGen.JTableActivityValidator>? TheActivityValidatorList { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[ForeignKey("JBACTIVITYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBActivity? TheJBActivity { get; set; }

		[InverseProperty("TheJTableReportActivity")]
		public virtual List<Anu.DynamicFormGen.JTableActivityValidatorHst>? TheJTableActivityValidatorHstList { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[ForeignKey("NEXTACTIVITYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBActivity? TheNextActivity { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PREVIOUSACTIVITYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBActivity? ThePreviousActivity { get; set; }

		[ForeignKey("RETURNEDOBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheReturnedObjectState { get; set; }

    }
    [Table("JTABLEREPORTACTIVITY")]
    public partial class JTableReportActivity : JTableReportActivityBase { }

    }


