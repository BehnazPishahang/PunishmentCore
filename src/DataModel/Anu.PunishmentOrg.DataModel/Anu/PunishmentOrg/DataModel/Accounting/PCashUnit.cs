

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PCashUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PCASHID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PCash? ThePCash { get; set; }

    }

    [Table("PCASHUNIT")]
    public partial class PCashUnit : PCashUnitBase
    {
    }
}