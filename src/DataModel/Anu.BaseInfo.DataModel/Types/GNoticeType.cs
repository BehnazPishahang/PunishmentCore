﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GNoticeTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Unicode(false)]
        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

        }

    [Table("GNOTICETYPE")]
    public partial class GNoticeType : GNoticeTypeBase
    {
    }
    }