

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Letter
{
    public abstract class GIncomingLetterSubjectBase : BaseInfoEntity<string>
    {

		[ForeignKey("GINCOMINGLETTERID")]
		public virtual Anu.Letter.GIncomingLetter? TheGIncomingLetter { get; set; }

		[ForeignKey("INPUTLETTERTYPEID")]
		public virtual Anu.BaseInfo.Types.InputLetterType? TheInputLetterType { get; set; }

    }
    [Table("GINCOMINGLETTERSUBJECT")]
    public partial class GIncomingLetterSubject : GIncomingLetterSubjectBase { }

    }


