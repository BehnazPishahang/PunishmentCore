

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISCaseTripleBase : PunishmentOrgEntity<string>
    {

        [Column("OFFENDERINVOLVEDTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OffenderInvolvedType? OffenderInvolvedType { get; set; }

        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [ForeignKey("CREATORCASEINPUTID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCaseInput? TheCreatorCaseInput { get; set; }

        [ForeignKey("OFFENDINGPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCasePerson? TheOffendingPerson { get; set; }

        [ForeignKey("PBINTRODUCTIONLITIGATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBIntroductionLitigation? ThePBIntroductionLitigation { get; set; }

        [ForeignKey("PCASETRIPLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseTriple? ThePCaseTriple { get; set; }

        [ForeignKey("PLAINTIFFPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCasePerson? ThePlaintiffPerson { get; set; }

        [ForeignKey("PMISCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCase? ThePMISCase { get; set; }

        [ForeignKey("PMISCASEVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCaseViolation? ThePMISCaseViolation { get; set; }

        [ForeignKey("RELATEDCASEINPUTID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCaseInput? TheRelatedCaseInput { get; set; }

    }

    [Table("PMISCASETRIPLE")]
    public partial class PMISCaseTriple : PMISCaseTripleBase
    {
    }
}