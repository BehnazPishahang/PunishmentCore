

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Expert
{
    public abstract class ExpertBackgroundBase : BaseInfoEntity<string>
    {

		[Column("EXPERTSTATE")]
		public virtual Anu.Enumerations.ExpertState? ExpertState { get; set; }

		[Column("FROMDATE")]
		public virtual string? FromDate { get; set; }

		[ForeignKey("EXPERTMANID")]
		public virtual Anu.BaseInfo.Expert.ExpertMan? TheExpertMan { get; set; }

		[Column("TODATE")]
		public virtual string? ToDate { get; set; }

    }
    [Table("EXPERTBACKGROUND")]
    public partial class ExpertBackground : ExpertBackgroundBase { }

    }


