

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenRejectOrDefectRSBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBGRAVAMENREJECTDEFECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBGravamenRejectDefectType? ThePBGravamenRejectDefectType { get; set; }

        [ForeignKey("PGRAVAMENID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

    }

    [Table("PGRAVAMENREJECTORDEFECTRS")]
    public partial class PGravamenRejectOrDefectRS : PGravamenRejectOrDefectRSBase
    {
    }
}