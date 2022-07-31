

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterSubjectBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("POUTGOINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    }

    [Table("POUTGOINGLETTERSUBJECT")]
    public partial class POutgoingLetterSubject : POutgoingLetterSubjectBase
    {
    }
    }