﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESUserAccessBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATETIME")]
        public virtual string? FromDateTime { get; set; }

        [Unicode(false)]
        [Column("SIGNTEXT")]
        public virtual string? SignText { get; set; }

        [ForeignKey("GFESUSERID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser? TheGFESUser { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [InverseProperty("TheGFESUserAccess")]
        public virtual List<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserRoleFavMenu>? TheGFESUserRoleFavMenuList { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [Unicode(false)]
        [Column("TODATETIME")]
        public virtual string? ToDateTime { get; set; }

        }

    [Table("GFESUSERACCESS")]
    public partial class GFESUserAccess : GFESUserAccessBase
    {
    }
    }