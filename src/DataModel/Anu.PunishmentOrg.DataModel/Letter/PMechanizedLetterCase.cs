

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PMechanizedLetterCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

    }

    [Table("PMECHANIZEDLETTERCASE")]
    public partial class PMechanizedLetterCase : PMechanizedLetterCaseBase
    {
    }
}