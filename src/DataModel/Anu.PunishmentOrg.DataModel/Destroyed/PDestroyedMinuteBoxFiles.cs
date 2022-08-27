using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedMinuteBoxFilesBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBOXFILEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PBoxFile? ThePBoxFile { get; set; }

        [ForeignKey("PDESTROYEDMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

        }

    [Table("PDESTROYEDMINUTEBOXFILES")]
    public partial class PDestroyedMinuteBoxFiles : PDestroyedMinuteBoxFilesBase
    {
    }
    }