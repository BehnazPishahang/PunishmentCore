

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PTreasuryRandomNumBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ISPAID")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPaid { get; set; }

        [Column("POSNUMBER")]
        public virtual string? POSNumber { get; set; }

        [Column("TREASURYNUMBER")]
        public virtual string? TreasuryNumber { get; set; }

    }

    [Table("PTREASURYRANDOMNUM")]
    public partial class PTreasuryRandomNum : PTreasuryRandomNumBase
    {
    }
}