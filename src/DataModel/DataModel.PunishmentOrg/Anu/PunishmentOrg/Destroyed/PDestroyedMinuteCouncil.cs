

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedMinuteCouncilBase : PunishmentOrgEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("PRESENTPOST")]
		public virtual Anu.Enumerations.PunishmentOrg.DestroyedMinuteCouncil? PresentPost { get; set; }

		[Column("SEX")]
		public virtual Anu.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("PDESTROYEDMINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

    }
    [Table("PDESTROYEDMINUTECOUNCIL")]
    public partial class PDestroyedMinuteCouncil : PDestroyedMinuteCouncilBase { }

    }


