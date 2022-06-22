

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Letter
{
    public abstract class GOutgoingLetterSubjectBase : BaseInfoEntity<string>
    {

		[ForeignKey("GOUTGOINGLETTERID")]
		public virtual Anu.Letter.GOutgoingLetter? TheGOutgoingLetter { get; set; }

		[ForeignKey("OUTPUTLETTERTYPEID")]
		public virtual Anu.BaseInfo.Types.OutputLetterType? TheOutputLetterType { get; set; }

    }
    [Table("GOUTGOINGLETTERSUBJECT")]
    public partial class GOutgoingLetterSubject : GOutgoingLetterSubjectBase { }

    }


