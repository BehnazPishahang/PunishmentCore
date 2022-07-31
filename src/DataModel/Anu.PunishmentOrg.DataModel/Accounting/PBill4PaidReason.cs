

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PBill4PaidReasonBase : PunishmentOrgEntity<string>
    {

        [Column("BASEAMOUNT")]
        public virtual long? BaseAmount { get; set; }

        [Column("DEBTREDUCTIONVALUE")]
        public virtual long? DebtReductionValue { get; set; }

        [Column("DISCOUNTSTATE")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? DiscountState { get; set; }

        [Unicode(false)]
        [Column("OLDCASEBINDINGIDS")]
        public virtual string? OldCaseBindingIDs { get; set; }

        [Column("PAIDCOST")]
        public virtual long? PaidCost { get; set; }

        [Unicode(false)]
        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocId { get; set; }

        [Unicode(false)]
        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [ForeignKey("PBCASHTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBCashType? ThePBCashType { get; set; }

        [ForeignKey("PBILL4PAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PINSTALLMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PInstallment? ThePInstallment { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

    }

    [Table("PBILL4PAIDREASON")]
    public partial class PBill4PaidReason : PBill4PaidReasonBase
    {
    }
    }