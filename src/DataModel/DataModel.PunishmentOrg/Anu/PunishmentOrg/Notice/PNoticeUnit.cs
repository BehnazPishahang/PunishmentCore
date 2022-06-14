

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PNOTICEID")]
		public virtual Anu.PunishmentOrg.Notice.PNotice? ThePNotice { get; set; }

    }
    [Table("PNOTICEUNIT")]
    public partial class PNoticeUnit : PNoticeUnitBase { }

    }


