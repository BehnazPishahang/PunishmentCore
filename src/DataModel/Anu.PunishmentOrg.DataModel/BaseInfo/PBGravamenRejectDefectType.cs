

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBGravamenRejectDefectTypeBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("REJECTORDEFECT")]
        public virtual Anu.PunishmentOrg.Enumerations.RejectOrDefect? RejectOrDefect { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBGRAVAMENREJECTDEFECTTYPE")]
    public partial class PBGravamenRejectDefectType : PBGravamenRejectDefectTypeBase
    {
    }
    }