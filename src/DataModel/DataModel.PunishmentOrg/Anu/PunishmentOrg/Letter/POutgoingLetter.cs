

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class POutgoingLetterBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[InverseProperty("ThePOutgoingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterCase>? ThePOutgoingLetterCaseList { get; set; }

		[InverseProperty("ThePOutgoingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterSendCase>? ThePOutgoingLetterSendCaseList { get; set; }

		[InverseProperty("ThePOutgoingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterSubject>? ThePOutgoingLetterSubjectList { get; set; }

		[InverseProperty("ThePOutgoingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterTranscript>? ThePOutgoingLetterTranscriptList { get; set; }

		[InverseProperty("ThePOutgoingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.POutgoingLetterUnit>? ThePOutgoingLetterUnitList { get; set; }

    }
    [Table("POUTGOINGLETTER")]
    public partial class POutgoingLetter : POutgoingLetterBase { }

    }


