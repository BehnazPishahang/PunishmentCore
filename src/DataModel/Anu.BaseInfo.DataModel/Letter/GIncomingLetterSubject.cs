

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Letter
{
    public abstract class GIncomingLetterSubjectBase : BaseInfoEntity<string>
    {

        [ForeignKey("GINCOMINGLETTERID")]
        public virtual Anu.BaseInfo.DataModel.Letter.GIncomingLetter? TheGIncomingLetter { get; set; }

        [ForeignKey("INPUTLETTERTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.InputLetterType? TheInputLetterType { get; set; }

    }

    [Table("GINCOMINGLETTERSUBJECT")]
    public partial class GIncomingLetterSubject : GIncomingLetterSubjectBase
    {
    }
    }