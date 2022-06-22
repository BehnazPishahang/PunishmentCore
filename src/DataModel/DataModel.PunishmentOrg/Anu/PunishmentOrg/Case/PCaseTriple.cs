

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseTripleBase : PunishmentOrgEntity<string>
    {

		[Column("OFFENDERINVOLVEDTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.OffenderInvolvedType? OffenderInvolvedType { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[ForeignKey("CREATORCASEINPUTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseInput? TheCreatorCaseInput { get; set; }

		[ForeignKey("OFFENDINGPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? TheOffendingPerson { get; set; }

		[ForeignKey("PBINTRODUCTIONLITIGATIONID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBIntroductionLitigation? ThePBIntroductionLitigation { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCASEVIOLATIONID")]
		public virtual Anu.PunishmentOrg.Case.PCaseViolation? ThePCaseViolation { get; set; }

		[InverseProperty("ThePCaseTriple")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentTriple>? ThePJudgmentTripleList { get; set; }

		[ForeignKey("PLAINTIFFPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePlaintiffPerson { get; set; }

		[InverseProperty("ThePCaseTriple")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequestTriple>? ThePRevisionRequestTripleList { get; set; }

		[InverseProperty("ThePCaseTriple")]
		public virtual List<Anu.PunishmentOrg.Terminate.PTerminateOrderTriple>? ThePTerminateOrderTripleList { get; set; }

		[ForeignKey("RELATEDCASEINPUTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseInput? TheRelatedCaseInput { get; set; }

    }
    [Table("PCASETRIPLE")]
    public partial class PCaseTriple : PCaseTripleBase { }

    }


