using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Letter;


namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterBase : GOutgoingLetter
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

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("POUTGOINGLETTER")]
    public partial class POutgoingLetter : POutgoingLetterBase
    {
    }
    }