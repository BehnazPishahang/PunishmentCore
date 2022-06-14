

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Explorer
{
    public abstract class ExplorerTransParamSettingBase : BaseInfoEntity<string>
    {

		[ForeignKey("EXPLORERNODEINPUTPARAMID")]
		public virtual Rad.Explorer.ExplorerNodeInputParam? TheExplorerNodeInputParam { get; set; }

		[Column("VALUE")]
		public virtual string? Value { get; set; }

    }
    [Table("EXPLORERTRANSPARAMSETTING")]
    public partial class ExplorerTransParamSetting : ExplorerTransParamSettingBase { }

    }


