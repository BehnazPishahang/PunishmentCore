

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBIntroductionLitigationBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("REQUESTSUBJECT")]
        public virtual Anu.PunishmentOrg.Enumerations.PURevisionRequestSubject? RequestSubject { get; set; }

        [Column("STATE")]
        public virtual Anu.PunishmentOrg.Enumerations.PULegalPersonState? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Unicode(false)]
        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("PBINTRODUCTIONLITIGATION")]
    public partial class PBIntroductionLitigation : PBIntroductionLitigationBase
    {
    }
    }