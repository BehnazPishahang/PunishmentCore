

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PForm5MinuteConfirmerBase : PunishmentOrgEntity<string>
    {

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PRESENTPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.DestroyedMinutePresent? PresentPost { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("PFORM5MINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PForm5Minute? ThePForm5Minute { get; set; }

    }

    [Table("PFORM5MINUTECONFIRMER")]
    public partial class PForm5MinuteConfirmer : PForm5MinuteConfirmerBase
    {
    }
}