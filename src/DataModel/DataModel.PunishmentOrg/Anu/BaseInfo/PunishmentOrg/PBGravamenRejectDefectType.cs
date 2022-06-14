﻿

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBGravamenRejectDefectTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("REJECTORDEFECT")]
		public virtual Anu.Enumerations.PunishmentOrg.RejectOrDefect? RejectOrDefect { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBGRAVAMENREJECTDEFECTTYPE")]
    public partial class PBGravamenRejectDefectType : PBGravamenRejectDefectTypeBase { }

    }


