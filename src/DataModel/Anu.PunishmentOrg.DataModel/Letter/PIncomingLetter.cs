

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PIncomingLetterBase : PunishmentOrgEntity<string>
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

    }

    [Table("PINCOMINGLETTER")]
    public partial class PIncomingLetter : PIncomingLetterBase
    {
    }
    }