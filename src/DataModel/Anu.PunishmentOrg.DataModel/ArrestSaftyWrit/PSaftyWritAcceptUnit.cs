

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PSaftyWritAcceptUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PSAFTYWRITACCEPTID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritAccept? ThePSaftyWritAccept { get; set; }

    }

    [Table("PSAFTYWRITACCEPTUNIT")]
    public partial class PSaftyWritAcceptUnit : PSaftyWritAcceptUnitBase
    {
    }
    }