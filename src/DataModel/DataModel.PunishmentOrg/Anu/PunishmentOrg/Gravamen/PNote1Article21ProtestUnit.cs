

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Gravamen
{
    public abstract class PNote1Article21ProtestUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PNOTE1ARTICLE21PROTESTID")]
		public virtual Anu.PunishmentOrg.Gravamen.PNote1Article21Protest? ThePNote1Article21Protest { get; set; }

    }
    [Table("PNOTE1ARTICLE21PROTESTUNIT")]
    public partial class PNote1Article21ProtestUnit : PNote1Article21ProtestUnitBase { }

    }


