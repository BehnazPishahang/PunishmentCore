

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedMinuteImagesBase : PunishmentOrgEntity<string>
    {

		[Column("DOCIMAGE")]
		public virtual byte[]? DocImage { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[ForeignKey("PDESTROYEDMINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

    }
    [Table("PDESTROYEDMINUTEIMAGES")]
    public partial class PDestroyedMinuteImages : PDestroyedMinuteImagesBase { }

    }


