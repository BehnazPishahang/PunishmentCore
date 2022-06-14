

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Individual
{
    public abstract class FingerPointBase : BaseInfoEntity<string>
    {

		[Column("FINGER")]
		public virtual Rad.CMS.Enumerations.Finger? Finger { get; set; }

		[Column("FINGERCODE")]
		public virtual string? FingerCode { get; set; }

		[Column("FINGERIMAGE")]
		public virtual byte[]? FingerImage { get; set; }

		[ForeignKey("INDIVIDUALID")]
		public virtual Rad.BaseInfo.Individual.Individual? TheIndividual { get; set; }

    }
    [Table("FINGERPOINT")]
    public partial class FingerPoint : FingerPointBase { }

    }


