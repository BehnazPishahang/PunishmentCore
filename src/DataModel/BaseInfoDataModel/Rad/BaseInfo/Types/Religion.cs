

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class ReligionBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheReligion")]
		public virtual List<Rad.BaseInfo.Types.ReligionIdeology>? TheReligionIdeologyList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("RELIGION")]
    public partial class Religion : ReligionBase { }

    }


