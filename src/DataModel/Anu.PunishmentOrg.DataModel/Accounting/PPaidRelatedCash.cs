

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PPaidRelatedCashBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASHID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PCash? ThePCash { get; set; }

        [ForeignKey("PPAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PPaid? ThePPaid { get; set; }

    }

    [Table("PPAIDRELATEDCASH")]
    public partial class PPaidRelatedCash : PPaidRelatedCashBase
    {
    }
}