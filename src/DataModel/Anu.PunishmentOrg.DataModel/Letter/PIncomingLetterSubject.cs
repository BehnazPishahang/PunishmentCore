

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PIncomingLetterSubjectBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PINCOMINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

    }

    [Table("PINCOMINGLETTERSUBJECT")]
    public partial class PIncomingLetterSubject : PIncomingLetterSubjectBase
    {
    }
    }