

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PTerminateOrderCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PTERMINATEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

    }

    [Table("PTERMINATEORDERCASE")]
    public partial class PTerminateOrderCase : PTerminateOrderCaseBase
    {
    }
}