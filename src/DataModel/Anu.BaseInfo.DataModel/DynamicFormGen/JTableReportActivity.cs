using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportActivityBase : BaseInfoEntity<string>
    {

        [Column("ACCESSDATATYPE")]
        public virtual Anu.BaseInfo.Enumerations.ReportAccessDataType? AccessDataType { get; set; }

        [Column("ACTIVITYORDER")]
        public virtual decimal? ActivityOrder { get; set; }

        [Column("ISACTIVE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsActive { get; set; }

        [Column("ISAFTERFINALSTATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsAfterFinalState { get; set; }

        [Column("ISFINALLYACTIVITY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsFinallyActivity { get; set; }

        [Column("ISMAINACTIVITY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMainActivity { get; set; }

        [Column("ISRETURNAFTERFINALSTATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsReturnAfterFinalState { get; set; }

        [Column("ISSTARTERACTIVITY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsStarterActivity { get; set; }

        [Column("REVERSIBLE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? Reversible { get; set; }

        [InverseProperty("TheActivity")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableActivityValidator>? TheActivityValidatorList { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [ForeignKey("JBACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBActivity? TheJBActivity { get; set; }

        [InverseProperty("TheJTableReportActivity")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableActivityValidatorHst>? TheJTableActivityValidatorHstList { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [ForeignKey("NEXTACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBActivity? TheNextActivity { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PREVIOUSACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBActivity? ThePreviousActivity { get; set; }

        [ForeignKey("RETURNEDOBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheReturnedObjectState { get; set; }

        }

    [Table("JTABLEREPORTACTIVITY")]
    public partial class JTableReportActivity : JTableReportActivityBase
    {
    }
    }