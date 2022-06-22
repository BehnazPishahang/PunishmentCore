

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseAgentBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("AGENTID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? TheAgent { get; set; }

		[ForeignKey("AGENTEDID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? TheAgented { get; set; }

		[ForeignKey("AGENTTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.AgentType? TheAgentType { get; set; }

    }
    [Table("PCASEAGENT")]
    public partial class PCaseAgent : PCaseAgentBase { }

    }


