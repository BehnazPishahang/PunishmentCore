

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBBindingSubjectTypeBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("IS4GOODSCURRENCY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? Is4GoodsCurrency { get; set; }

        [Column("PENALTYTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUPenaltyType? PenaltyType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBBINDINGSUBJECTTYPE")]
    public partial class PBBindingSubjectType : PBBindingSubjectTypeBase
    {
    }
    }