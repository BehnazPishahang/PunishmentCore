

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PIncomingLetterCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PINCOMINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

    }

    [Table("PINCOMINGLETTERCASE")]
    public partial class PIncomingLetterCase : PIncomingLetterCaseBase
    {
    }
    }