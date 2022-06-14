

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GPersonTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGPersonType")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestPerson>? TheGRequestPersonList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GPERSONTYPE")]
    public partial class GPersonType : GPersonTypeBase { }

    }


