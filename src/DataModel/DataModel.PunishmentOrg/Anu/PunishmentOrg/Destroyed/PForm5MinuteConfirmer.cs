

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PForm5MinuteConfirmerBase : PunishmentOrgEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("PRESENTPOST")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DestroyedMinutePresent? PresentPost { get; set; }

		[Column("SEX")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.SexType? Sex { get; set; }

		[ForeignKey("PFORM5MINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PForm5Minute? ThePForm5Minute { get; set; }

    }
    [Table("PFORM5MINUTECONFIRMER")]
    public partial class PForm5MinuteConfirmer : PForm5MinuteConfirmerBase { }

    }


