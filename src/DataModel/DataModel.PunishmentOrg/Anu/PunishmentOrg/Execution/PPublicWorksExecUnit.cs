

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PPublicWorksExecUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PPUBLICWORKSEXECID")]
		public virtual Anu.PunishmentOrg.Execution.PPublicWorksExec? ThePPublicWorksExec { get; set; }

    }
    [Table("PPUBLICWORKSEXECUNIT")]
    public partial class PPublicWorksExecUnit : PPublicWorksExecUnitBase { }

    }


