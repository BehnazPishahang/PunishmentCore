

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PCaseVehiclePersonBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PCASEVEHICLEID")]
		public virtual Anu.PunishmentOrg.Case.PCaseVehicle? ThePCaseVehicle { get; set; }

    }
    [Table("PCASEVEHICLEPERSON")]
    public partial class PCaseVehiclePerson : PCaseVehiclePersonBase { }

    }


