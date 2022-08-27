using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PRegistaryTimeCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PREGISTARYTIMEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PRegistaryTime? ThePRegistaryTime { get; set; }

        }

    [Table("PREGISTARYTIMECASE")]
    public partial class PRegistaryTimeCase : PRegistaryTimeCaseBase
    {
    }
    }