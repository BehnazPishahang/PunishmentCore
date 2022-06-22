

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISCaseTripleBase : PunishmentOrgEntity<string>
    {

		[Column("OFFENDERINVOLVEDTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.OffenderInvolvedType? OffenderInvolvedType { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[ForeignKey("CREATORCASEINPUTID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCaseInput? TheCreatorCaseInput { get; set; }

		[ForeignKey("OFFENDINGPERSONID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCasePerson? TheOffendingPerson { get; set; }

		[ForeignKey("PBINTRODUCTIONLITIGATIONID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBIntroductionLitigation? ThePBIntroductionLitigation { get; set; }

		[ForeignKey("PCASETRIPLEID")]
		public virtual Anu.PunishmentOrg.Case.PCaseTriple? ThePCaseTriple { get; set; }

		[ForeignKey("PLAINTIFFPERSONID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCasePerson? ThePlaintiffPerson { get; set; }

		[ForeignKey("PMISCASEID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCase? ThePMISCase { get; set; }

		[ForeignKey("PMISCASEVIOLATIONID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCaseViolation? ThePMISCaseViolation { get; set; }

		[ForeignKey("RELATEDCASEINPUTID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCaseInput? TheRelatedCaseInput { get; set; }

    }
    [Table("PMISCASETRIPLE")]
    public partial class PMISCaseTriple : PMISCaseTripleBase { }

    }


