﻿

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBForgivenessTypeBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBFORGIVENESSTYPE")]
    public partial class PBForgivenessType : PBForgivenessTypeBase
    {
    }
    }