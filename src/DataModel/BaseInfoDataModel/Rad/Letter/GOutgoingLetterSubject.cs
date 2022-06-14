

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
{
    public abstract class GOutgoingLetterSubjectBase : BaseInfoEntity<string>
    {

		[ForeignKey("OUTPUTLETTERTYPEID")]
		public virtual Rad.BaseInfo.Types.OutputLetterType? TheOutputLetterType { get; set; }

    }
    [Table("GOUTGOINGLETTERSUBJECT")]
    public partial class GOutgoingLetterSubject : GOutgoingLetterSubjectBase { }

    }


