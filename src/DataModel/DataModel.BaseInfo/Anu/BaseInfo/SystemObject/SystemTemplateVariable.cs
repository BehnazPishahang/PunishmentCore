

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class SystemTemplateVariableBase : BaseInfoEntity<string>
    {

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("FARSIPATH")]
		public virtual string? FarsiPath { get; set; }

		[Column("LATINPATH")]
		public virtual string? LatinPath { get; set; }

		[Column("TYPE")]
		public virtual Anu.Enumerations.WorkFlowDataType? Type { get; set; }

    }
    [Table("SYSTEMTEMPLATEVARIABLE")]
    public partial class SystemTemplateVariable : SystemTemplateVariableBase { }

    }


