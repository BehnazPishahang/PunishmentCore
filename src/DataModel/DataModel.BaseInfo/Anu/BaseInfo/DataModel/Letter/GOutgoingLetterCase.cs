

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Letter
{
    public abstract class GOutgoingLetterCaseBase : BaseInfoEntity<string>
    {

        [Column("CASEMECHANIZESTATE")]
        public virtual Anu.BaseInfo.Enumerations.CaseMechanizeState? CaseMechanizeState { get; set; }

        [Column("CASEOWNER")]
        public virtual Anu.BaseInfo.Enumerations.CaseOwner? CaseOwner { get; set; }

        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Column("RELATEDCASETITLE")]
        public virtual string? RelatedCaseTitle { get; set; }

        [ForeignKey("GOUTGOINGLETTERID")]
        public virtual Anu.BaseInfo.DataModel.Letter.GOutgoingLetter? TheGOutgoingLetter { get; set; }

        [ForeignKey("RELATEDCASECLASSID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

        [ForeignKey("RELATEDCASEFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

    }

    [Table("GOUTGOINGLETTERCASE")]
    public partial class GOutgoingLetterCase : GOutgoingLetterCaseBase
    {
    }
}