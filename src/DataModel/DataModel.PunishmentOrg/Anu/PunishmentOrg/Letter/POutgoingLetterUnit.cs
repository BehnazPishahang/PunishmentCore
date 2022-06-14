

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class POutgoingLetterUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("POUTGOINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    }
    [Table("POUTGOINGLETTERUNIT")]
    public partial class POutgoingLetterUnit : POutgoingLetterUnitBase { }

    }


