

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemObject
{
    public abstract class SystemTemplateLoopBase : BaseInfoEntity<string>
    {

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("FARSIPATH")]
		public virtual string? FarsiPath { get; set; }

		[Column("LATINNAME")]
		public virtual string? LatinName { get; set; }

		[Column("LATINPATH")]
		public virtual string? LatinPath { get; set; }

		[Column("ROWNO")]
		public virtual long? RowNo { get; set; }

		[ForeignKey("LOOPTEMPLATEID")]
		public virtual Anu.BaseInfo.SystemObject.SystemTemplate? TheLoopTemplate { get; set; }

		[ForeignKey("SYSTEMCONDITIONID")]
		public virtual Anu.BaseInfo.SystemObject.SystemCondition? TheSystemCondition { get; set; }

    }
    [Table("SYSTEMTEMPLATELOOP")]
    public partial class SystemTemplateLoop : SystemTemplateLoopBase { }

    }


