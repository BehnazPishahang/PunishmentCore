

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PForm5MinuteImagesBase : PunishmentOrgEntity<string>
    {

		[Column("DOCIMAGE")]
		public virtual byte[]? DocImage { get; set; }

		[Column("IMAGETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.Form5Images? ImageType { get; set; }

		[ForeignKey("PFORM5MINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PForm5Minute? ThePForm5Minute { get; set; }

    }
    [Table("PFORM5MINUTEIMAGES")]
    public partial class PForm5MinuteImages : PForm5MinuteImagesBase { }

    }


