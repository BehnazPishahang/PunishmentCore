using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Letter;


namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PIncomingLetterBase : GIncomingLetter
    {

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [InverseProperty("ThePIncomingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PIncomingLetterCase>? ThePIncomingLetterCaseList { get; set; }

        [InverseProperty("ThePIncomingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PIncomingLetterSubject>? ThePIncomingLetterSubjectList { get; set; }

        [InverseProperty("ThePIncomingLetter")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PIncomingLetterUnit>? ThePIncomingLetterUnitList { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PINCOMINGLETTER")]
    public partial class PIncomingLetter : PIncomingLetterBase
    {
    }
    }