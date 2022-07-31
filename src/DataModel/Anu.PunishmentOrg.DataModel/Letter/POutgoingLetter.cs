

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [InverseProperty("ThePOutgoingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterCase>? ThePOutgoingLetterCaseList { get; set; }

        [InverseProperty("ThePOutgoingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterSendCase>? ThePOutgoingLetterSendCaseList { get; set; }

        [InverseProperty("ThePOutgoingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterSubject>? ThePOutgoingLetterSubjectList { get; set; }

        [InverseProperty("ThePOutgoingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterTranscript>? ThePOutgoingLetterTranscriptList { get; set; }

        [InverseProperty("ThePOutgoingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.POutgoingLetterUnit>? ThePOutgoingLetterUnitList { get; set; }

    }

    [Table("POUTGOINGLETTER")]
    public partial class POutgoingLetter : POutgoingLetterBase
    {
    }
    }