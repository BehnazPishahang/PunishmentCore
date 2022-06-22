

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedCaseImagesBase : PunishmentOrgEntity<string>
    {

		[Column("DOCIMAGE")]
		public virtual byte[]? DocImage { get; set; }

		[ForeignKey("ATTACHMENTTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.AttachmentType? TheAttachmentType { get; set; }

		[ForeignKey("PDESTROYEDCASEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

    }
    [Table("PDESTROYEDCASEIMAGES")]
    public partial class PDestroyedCaseImages : PDestroyedCaseImagesBase { }

    }


