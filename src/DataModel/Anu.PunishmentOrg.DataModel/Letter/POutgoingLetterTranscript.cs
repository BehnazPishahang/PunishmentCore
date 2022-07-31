

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterTranscriptBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("POUTGOINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    }

    [Table("POUTGOINGLETTERTRANSCRIPT")]
    public partial class POutgoingLetterTranscript : POutgoingLetterTranscriptBase
    {
    }
    }