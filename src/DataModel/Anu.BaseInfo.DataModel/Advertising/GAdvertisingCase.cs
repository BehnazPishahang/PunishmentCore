using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Advertising
{
    public abstract class GAdvertisingCaseBase : BaseInfoEntity<string>
    {

        [Column("CASEMECHANIZESTATE")]
        public virtual Anu.BaseInfo.Enumerations.CaseMechanizeState? CaseMechanizeState { get; set; }

        [Column("CASEOWNER")]
        public virtual Anu.BaseInfo.Enumerations.CaseOwner? CaseOwner { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASETITLE")]
        public virtual string? RelatedCaseTitle { get; set; }

        [ForeignKey("GADVERTISINGID")]
        public virtual Anu.BaseInfo.DataModel.Advertising.GAdvertising? TheGAdvertising { get; set; }

        [ForeignKey("RELATEDCASECLASSID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

        [ForeignKey("RELATEDCASEFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

        }

    [Table("GADVERTISINGCASE")]
    public partial class GAdvertisingCase : GAdvertisingCaseBase
    {
    }
    }