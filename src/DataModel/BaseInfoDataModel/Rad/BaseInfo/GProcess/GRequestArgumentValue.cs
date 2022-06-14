

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestArgumentValueBase : BaseInfoEntity<string>
    {

		[ForeignKey("GPROCESSSTEPARGUMENTID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStepArgument? TheGProcessStepArgument { get; set; }

		[ForeignKey("GREQUESTREFERID")]
		public virtual Rad.BaseInfo.GProcess.GRequestRefer? TheGRequestRefer { get; set; }

		[Column("VALUE")]
		public virtual string? Value { get; set; }

    }
    [Table("GREQUESTARGUMENTVALUE")]
    public partial class GRequestArgumentValue : GRequestArgumentValueBase { }

    }


