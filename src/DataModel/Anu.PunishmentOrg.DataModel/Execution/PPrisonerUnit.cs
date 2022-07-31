

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPrisonerUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PPRISONERID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PPrisoner? ThePPrisoner { get; set; }

    }

    [Table("PPRISONERUNIT")]
    public partial class PPrisonerUnit : PPrisonerUnitBase
    {
    }
    }