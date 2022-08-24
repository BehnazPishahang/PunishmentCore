using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Letter
{
    public abstract class GOutgoingLetterSubjectBase : BaseInfoEntity<string>
    {

        [ForeignKey("GOUTGOINGLETTERID")]
        public virtual Anu.BaseInfo.DataModel.Letter.GOutgoingLetter? TheGOutgoingLetter { get; set; }

        [ForeignKey("OUTPUTLETTERTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.OutputLetterType? TheOutputLetterType { get; set; }

        }

    [Table("GOUTGOINGLETTERSUBJECT")]
    public partial class GOutgoingLetterSubject : GOutgoingLetterSubjectBase
    {
    }
    }