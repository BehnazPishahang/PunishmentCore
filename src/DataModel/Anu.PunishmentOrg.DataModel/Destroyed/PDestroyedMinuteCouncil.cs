

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedMinuteCouncilBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PRESENTPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.DestroyedMinuteCouncil? PresentPost { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("PDESTROYEDMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

    }

    [Table("PDESTROYEDMINUTECOUNCIL")]
    public partial class PDestroyedMinuteCouncil : PDestroyedMinuteCouncilBase
    {
    }
    }