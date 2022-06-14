﻿

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class BaseRoleVariableBase : BaseInfoEntity<string>
    {

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("LATINNAME")]
		public virtual string? LatinName { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TYPE")]
		public virtual Rad.CMS.Enumerations.WorkFlowDataType? Type { get; set; }

    }
    [Table("BASEROLEVARIABLE")]
    public partial class BaseRoleVariable : BaseRoleVariableBase { }

    }


