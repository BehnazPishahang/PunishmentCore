

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
{
    public abstract class GIncomingLetterSubjectBase : BaseInfoEntity<string>
    {

		[ForeignKey("INPUTLETTERTYPEID")]
		public virtual Rad.BaseInfo.Types.InputLetterType? TheInputLetterType { get; set; }

    }
    [Table("GINCOMINGLETTERSUBJECT")]
    public partial class GIncomingLetterSubject : GIncomingLetterSubjectBase { }

    }


