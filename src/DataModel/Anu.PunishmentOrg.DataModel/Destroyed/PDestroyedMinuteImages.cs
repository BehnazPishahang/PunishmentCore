using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedMinuteImagesBase : PunishmentOrgEntity<string>
    {

        [Column("DOCIMAGE")]
        public virtual byte[]? DocImage { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PDESTROYEDMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

        }

    [Table("PDESTROYEDMINUTEIMAGES")]
    public partial class PDestroyedMinuteImages : PDestroyedMinuteImagesBase
    {
    }
    }