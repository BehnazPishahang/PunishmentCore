

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBCourtMemberBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("MEMBERTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUMemberType? MemberType { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PRINTORDER")]
        public virtual long? PrintOrder { get; set; }

        [Unicode(false)]
        [Column("SIGNTEXT")]
        public virtual string? SignText { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PBCOURTMEMBER")]
    public partial class PBCourtMember : PBCourtMemberBase
    {
    }
    }