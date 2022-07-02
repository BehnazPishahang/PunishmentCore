

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedMinutePresentBase : PunishmentOrgEntity<string>
    {

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PRESENTPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.DestroyedMinutePresent? PresentPost { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("PDESTROYEDMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("PDESTROYEDMINUTEPRESENT")]
    public partial class PDestroyedMinutePresent : PDestroyedMinutePresentBase
    {
    }
}