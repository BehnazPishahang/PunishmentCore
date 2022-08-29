using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        }

    [Table("PJUDGMENTUNIT")]
    public partial class PJudgmentUnit : PJudgmentUnitBase
    {
    }
    }