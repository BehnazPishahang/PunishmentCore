

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PTreasuryRandomNumBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ISPAID")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPaid { get; set; }

        [Unicode(false)]
        [Column("POSNUMBER")]
        public virtual string? POSNumber { get; set; }

        [Unicode(false)]
        [Column("TREASURYNUMBER")]
        public virtual string? TreasuryNumber { get; set; }

    }

    [Table("PTREASURYRANDOMNUM")]
    public partial class PTreasuryRandomNum : PTreasuryRandomNumBase
    {
    }
    }