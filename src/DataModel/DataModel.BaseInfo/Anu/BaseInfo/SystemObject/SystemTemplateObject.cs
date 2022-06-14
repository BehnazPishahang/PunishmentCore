

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemObject
{
    public abstract class SystemTemplateObjectBase : BaseInfoEntity<string>
    {

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("LATINNAME")]
		public virtual string? LatinName { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TYPE")]
		public virtual Anu.Enumerations.WorkFlowDataType? Type { get; set; }

    }
    [Table("SYSTEMTEMPLATEOBJECT")]
    public partial class SystemTemplateObject : SystemTemplateObjectBase { }

    }


