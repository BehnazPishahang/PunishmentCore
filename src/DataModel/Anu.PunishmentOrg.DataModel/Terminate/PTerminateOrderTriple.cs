using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PTerminateOrderTripleBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBTERMINATEREASONID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTerminateReason? ThePBTerminateReason { get; set; }

        [ForeignKey("PCASETRIPLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseTriple? ThePCaseTriple { get; set; }

        [ForeignKey("PTERMINATEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

        }

    [Table("PTERMINATEORDERTRIPLE")]
    public partial class PTerminateOrderTriple : PTerminateOrderTripleBase
    {
    }
    }