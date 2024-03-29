﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Security.Role
{
    public abstract class PostRoleActivitySecurityBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [ForeignKey("ACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheActivity { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        }

    [Table("POSTROLEACTIVITYSECURITY")]
    public partial class PostRoleActivitySecurity : PostRoleActivitySecurityBase
    {
    }
    }