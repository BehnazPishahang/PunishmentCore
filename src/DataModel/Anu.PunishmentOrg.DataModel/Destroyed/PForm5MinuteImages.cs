using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PForm5MinuteImagesBase : PunishmentOrgEntity<string>
    {

        [Column("DOCIMAGE")]
        public virtual byte[]? DocImage { get; set; }

        [Column("IMAGETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.Form5Images? ImageType { get; set; }

        [ForeignKey("PFORM5MINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PForm5Minute? ThePForm5Minute { get; set; }

        }

    [Table("PFORM5MINUTEIMAGES")]
    public partial class PForm5MinuteImages : PForm5MinuteImagesBase
    {
    }
    }