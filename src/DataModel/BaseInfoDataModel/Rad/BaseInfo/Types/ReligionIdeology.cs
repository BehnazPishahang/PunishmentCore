

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class ReligionIdeologyBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("RELIGIONID")]
		public virtual Rad.BaseInfo.Types.Religion? TheReligion { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("RELIGIONIDEOLOGY")]
    public partial class ReligionIdeology : ReligionIdeologyBase { }

    }


