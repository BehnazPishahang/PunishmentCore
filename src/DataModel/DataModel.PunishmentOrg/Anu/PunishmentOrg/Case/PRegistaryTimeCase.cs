

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PRegistaryTimeCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PREGISTARYTIMEID")]
		public virtual Anu.PunishmentOrg.Case.PRegistaryTime? ThePRegistaryTime { get; set; }

    }
    [Table("PREGISTARYTIMECASE")]
    public partial class PRegistaryTimeCase : PRegistaryTimeCaseBase { }

    }


