

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class ShortCutKeysBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual decimal? Code { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("SHORTCUTKEYS")]
    public partial class ShortCutKeys : ShortCutKeysBase { }

    }


