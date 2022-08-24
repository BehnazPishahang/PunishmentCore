using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBReportTitleBase : BaseInfoEntity<string>
    {

        [Column("APPLICANTFUNCTION")]
        public virtual Anu.BaseInfo.Enumerations.ApplicantFunctionType? ApplicantFunction { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("FRMBUDGETTYPE")]
        public virtual Anu.BaseInfo.Enumerations.FrmBudgetType? FrmBudgetType { get; set; }

        [Unicode(false)]
        [Column("SHORTNAME")]
        public virtual string? ShortName { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheRelatedReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBReportRelateds>? TheMainFormList { get; set; }

        [InverseProperty("TheMainReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBReportRelateds>? TheRelatedReportList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("JBREPORTTITLE")]
    public partial class JBReportTitle : JBReportTitleBase
    {
    }
    }