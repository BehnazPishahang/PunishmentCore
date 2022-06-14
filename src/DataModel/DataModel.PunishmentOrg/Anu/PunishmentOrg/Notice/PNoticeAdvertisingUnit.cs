

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeAdvertisingUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PNOTICEADVERTISINGID")]
		public virtual Anu.PunishmentOrg.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

    }
    [Table("PNOTICEADVERTISINGUNIT")]
    public partial class PNoticeAdvertisingUnit : PNoticeAdvertisingUnitBase { }

    }


