

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseProductPersonBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PCASEPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseProduct? ThePCaseProduct { get; set; }

    }

    [Table("PCASEPRODUCTPERSON")]
    public partial class PCaseProductPerson : PCaseProductPersonBase
    {
    }
}