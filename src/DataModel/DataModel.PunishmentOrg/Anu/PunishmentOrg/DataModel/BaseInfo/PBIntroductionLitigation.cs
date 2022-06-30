﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBIntroductionLitigationBase : PunishmentOrgEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("PBINTRODUCTIONLITIGATION")]
    public partial class PBIntroductionLitigation : PBIntroductionLitigationBase
    {
    }
}