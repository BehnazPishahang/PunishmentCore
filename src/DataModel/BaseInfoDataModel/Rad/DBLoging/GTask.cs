

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class GTaskBase : BaseInfoEntity<string>
    {

		[Column("RUNNERTYPENAME")]
		public virtual string? RunnerTypeName { get; set; }

		[Column("TASKSTATE")]
		public virtual Rad.CMS.Enumerations.LongRunningTaskState? TaskState { get; set; }

		[InverseProperty("TheGTask")]
		public virtual List<Rad.DBLoging.GTaskParameter>? TheGTaskParameterList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GTASK")]
    public partial class GTask : GTaskBase { }

    }


