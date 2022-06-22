

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedMinuteBoxFilesBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBOXFILEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PBoxFile? ThePBoxFile { get; set; }

		[ForeignKey("PDESTROYEDMINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

    }
    [Table("PDESTROYEDMINUTEBOXFILES")]
    public partial class PDestroyedMinuteBoxFiles : PDestroyedMinuteBoxFilesBase { }

    }


