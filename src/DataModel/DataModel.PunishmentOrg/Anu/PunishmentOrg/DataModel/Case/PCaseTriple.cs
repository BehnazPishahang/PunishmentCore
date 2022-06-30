

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseTripleBase : PunishmentOrgEntity<string>
    {

        [Column("OFFENDERINVOLVEDTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OffenderInvolvedType? OffenderInvolvedType { get; set; }

        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [ForeignKey("CREATORCASEINPUTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseInput? TheCreatorCaseInput { get; set; }

        [ForeignKey("OFFENDINGPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? TheOffendingPerson { get; set; }

        [ForeignKey("PBINTRODUCTIONLITIGATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBIntroductionLitigation? ThePBIntroductionLitigation { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseViolation? ThePCaseViolation { get; set; }

        [InverseProperty("ThePCaseTriple")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentTriple>? ThePJudgmentTripleList { get; set; }

        [ForeignKey("PLAINTIFFPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePlaintiffPerson { get; set; }

        [InverseProperty("ThePCaseTriple")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestTriple>? ThePRevisionRequestTripleList { get; set; }

        [InverseProperty("ThePCaseTriple")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrderTriple>? ThePTerminateOrderTripleList { get; set; }

        [ForeignKey("RELATEDCASEINPUTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseInput? TheRelatedCaseInput { get; set; }

    }

    [Table("PCASETRIPLE")]
    public partial class PCaseTriple : PCaseTripleBase
    {
    }
}