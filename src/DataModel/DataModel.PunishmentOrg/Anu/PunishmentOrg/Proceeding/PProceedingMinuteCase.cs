

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
{
    public abstract class PProceedingMinuteCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PPROCEEDINGMINUTEID")]
		public virtual Anu.PunishmentOrg.Proceeding.PProceedingMinute? ThePProceedingMinute { get; set; }

    }
    [Table("PPROCEEDINGMINUTECASE")]
    public partial class PProceedingMinuteCase : PProceedingMinuteCaseBase { }

    }


