

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PMechanizedLetterPersonBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("GMECHANIZEDLETTERID")]
        public virtual Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

    }

    [Table("PMECHANIZEDLETTERPERSON")]
    public partial class PMechanizedLetterPerson : PMechanizedLetterPersonBase
    {
    }
}