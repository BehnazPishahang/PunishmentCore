

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBExecContinuationReasonBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULegalPersonState? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBEXECCONTINUATIONREASON")]
    public partial class PBExecContinuationReason : PBExecContinuationReasonBase
    {
    }
    }