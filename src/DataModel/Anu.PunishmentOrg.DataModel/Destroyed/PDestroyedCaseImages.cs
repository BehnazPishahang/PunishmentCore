using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedCaseImagesBase : PunishmentOrgEntity<string>
    {

        [Column("DOCIMAGE")]
        public virtual byte[]? DocImage { get; set; }

        [ForeignKey("ATTACHMENTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.AttachmentType? TheAttachmentType { get; set; }

        [ForeignKey("PDESTROYEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

        }

    [Table("PDESTROYEDCASEIMAGES")]
    public partial class PDestroyedCaseImages : PDestroyedCaseImagesBase
    {
    }
    }