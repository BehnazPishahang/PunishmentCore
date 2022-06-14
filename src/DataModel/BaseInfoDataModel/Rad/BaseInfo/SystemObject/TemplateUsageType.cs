

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class TemplateUsageTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("TEMPLATEUSAGETYPE")]
    public partial class TemplateUsageType : TemplateUsageTypeBase { }

    }


