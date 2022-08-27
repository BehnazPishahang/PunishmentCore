using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPublicWorksExecUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PPUBLICWORKSEXECID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExec? ThePPublicWorksExec { get; set; }

        }

    [Table("PPUBLICWORKSEXECUNIT")]
    public partial class PPublicWorksExecUnit : PPublicWorksExecUnitBase
    {
    }
    }