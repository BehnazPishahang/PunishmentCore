

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentIssuerBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("MEMBERTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUMemberType? MemberType { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PRINTORDER")]
        public virtual long? PrintOrder { get; set; }

        [Unicode(false)]
        [Column("SIGNTEXT")]
        public virtual string? SignText { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("PJUDGMENTISSUER")]
    public partial class PJudgmentIssuer : PJudgmentIssuerBase
    {
    }
    }