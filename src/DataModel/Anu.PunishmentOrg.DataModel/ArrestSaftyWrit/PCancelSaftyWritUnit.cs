

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PCancelSaftyWritUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PCANCELSAFTYWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PCancelSaftyWrit? ThePCancelSaftyWrit { get; set; }

    }

    [Table("PCANCELSAFTYWRITUNIT")]
    public partial class PCancelSaftyWritUnit : PCancelSaftyWritUnitBase
    {
    }
    }