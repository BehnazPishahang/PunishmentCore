

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PPaidUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PPAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PPaid? ThePPaid { get; set; }

    }

    [Table("PPAIDUNIT")]
    public partial class PPaidUnit : PPaidUnitBase
    {
    }
}