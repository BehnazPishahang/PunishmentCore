

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedMinutePresentBase : PunishmentOrgEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("PRESENTPOST")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DestroyedMinutePresent? PresentPost { get; set; }

		[Column("SEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("PDESTROYEDMINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PDESTROYEDMINUTEPRESENT")]
    public partial class PDestroyedMinutePresent : PDestroyedMinutePresentBase { }

    }


