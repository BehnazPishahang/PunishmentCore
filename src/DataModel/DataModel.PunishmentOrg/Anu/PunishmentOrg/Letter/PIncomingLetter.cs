

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class PIncomingLetterBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[InverseProperty("ThePIncomingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.PIncomingLetterCase>? ThePIncomingLetterCaseList { get; set; }

		[InverseProperty("ThePIncomingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.PIncomingLetterSubject>? ThePIncomingLetterSubjectList { get; set; }

		[InverseProperty("ThePIncomingLetter")]
		public virtual List<Anu.PunishmentOrg.Letter.PIncomingLetterUnit>? ThePIncomingLetterUnitList { get; set; }

    }
    [Table("PINCOMINGLETTER")]
    public partial class PIncomingLetter : PIncomingLetterBase { }

    }


