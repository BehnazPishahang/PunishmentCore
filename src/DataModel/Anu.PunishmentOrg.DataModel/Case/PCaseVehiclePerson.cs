

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseVehiclePersonBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PCASEVEHICLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseVehicle? ThePCaseVehicle { get; set; }

    }

    [Table("PCASEVEHICLEPERSON")]
    public partial class PCaseVehiclePerson : PCaseVehiclePersonBase
    {
    }
}