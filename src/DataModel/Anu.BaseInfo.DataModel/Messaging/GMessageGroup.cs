﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Messaging
{
    public abstract class GMessageGroupBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("GROUPTITLE")]
        public virtual string? GroupTitle { get; set; }

        [InverseProperty("TheGMessageGroup")]
        public virtual List<Anu.BaseInfo.DataModel.Messaging.GMessageGroupUsers>? TheGMessageGroupUsersList { get; set; }

        [ForeignKey("OWNERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheOwnerUser { get; set; }

        }

    [Table("GMESSAGEGROUP")]
    public partial class GMessageGroup : GMessageGroupBase
    {
    }
    }