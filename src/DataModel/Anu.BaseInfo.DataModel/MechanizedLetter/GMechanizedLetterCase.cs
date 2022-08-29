using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.MechanizedLetter
{
    public abstract class GMechanizedLetterCaseBase : BaseInfoEntity<string>
    {

        [Column("CASELOCATION")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterCaseLocation? CaseLocation { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASETITLE")]
        public virtual string? RelatedCaseTitle { get; set; }

        [ForeignKey("GMECHANIZEDLETTERID")]
        public virtual Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

        [ForeignKey("RELATEDCASECLASSID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

        [ForeignKey("RELATEDCASEFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("GMECHANIZEDLETTERCASE")]
    public partial class GMechanizedLetterCase : GMechanizedLetterCaseBase
    {
    }
    }