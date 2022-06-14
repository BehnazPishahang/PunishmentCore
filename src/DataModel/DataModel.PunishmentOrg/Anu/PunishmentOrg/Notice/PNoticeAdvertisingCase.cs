

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeAdvertisingCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PNOTICEADVERTISINGID")]
		public virtual Anu.PunishmentOrg.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

    }
    [Table("PNOTICEADVERTISINGCASE")]
    public partial class PNoticeAdvertisingCase : PNoticeAdvertisingCaseBase { }

    }


