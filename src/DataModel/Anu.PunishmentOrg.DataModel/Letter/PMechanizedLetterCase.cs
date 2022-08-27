using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.MechanizedLetter;


namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PMechanizedLetterCaseBase : GMechanizedLetterCase
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PMECHANIZEDLETTERCASE")]
    public partial class PMechanizedLetterCase : PMechanizedLetterCaseBase
    {
    }
    }