

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticePersonBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("EXPERTMANID")]
		public virtual Anu.BaseInfo.Expert.ExpertMan? TheExpertMan { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PNOTICEID")]
		public virtual Anu.PunishmentOrg.Notice.PNotice? ThePNotice { get; set; }

    }
    [Table("PNOTICEPERSON")]
    public partial class PNoticePerson : PNoticePersonBase { }

    }


