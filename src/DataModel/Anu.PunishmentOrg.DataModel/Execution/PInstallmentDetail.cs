

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PInstallmentDetailBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("DUEDATE")]
        public virtual string? DueDate { get; set; }

        [Column("INSTALLMENTAMOUNT")]
        public virtual long? InstallmentAmount { get; set; }

        [Column("PAYAMOUNT")]
        public virtual long? PayAmount { get; set; }

        [Unicode(false)]
        [Column("PAYDATE")]
        public virtual string? PayDate { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PINSTALLMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PInstallment? ThePInstallment { get; set; }

        [InverseProperty("ThePInstallmentDetail")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidReason>? ThePPaidReasonList { get; set; }

    }

    [Table("PINSTALLMENTDETAIL")]
    public partial class PInstallmentDetail : PInstallmentDetailBase
    {
    }
    }