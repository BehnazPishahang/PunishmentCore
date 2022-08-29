using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseAgentBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("AGENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? TheAgent { get; set; }

        [ForeignKey("AGENTEDID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? TheAgented { get; set; }

        [ForeignKey("AGENTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.AgentType? TheAgentType { get; set; }

        }

    [Table("PCASEAGENT")]
    public partial class PCaseAgent : PCaseAgentBase
    {
    }
    }