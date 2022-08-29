using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Letter;


namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PIncomingLetterSubjectBase : GIncomingLetterSubject
    {

        [ForeignKey("PINCOMINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PINCOMINGLETTERSUBJECT")]
    public partial class PIncomingLetterSubject : PIncomingLetterSubjectBase
    {
    }
    }