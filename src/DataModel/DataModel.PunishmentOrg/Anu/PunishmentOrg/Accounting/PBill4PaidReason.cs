

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PBill4PaidReasonBase : PunishmentOrgEntity<string>
    {

		[Column("BASEAMOUNT")]
		public virtual long? BaseAmount { get; set; }

		[Column("DEBTREDUCTIONVALUE")]
		public virtual long? DebtReductionValue { get; set; }

		[Column("DISCOUNTSTATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.HaveNoHave? DiscountState { get; set; }

		[Column("OLDCASEBINDINGIDS")]
		public virtual string? OldCaseBindingIDs { get; set; }

		[Column("PAIDCOST")]
		public virtual long? PaidCost { get; set; }

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocId { get; set; }

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[ForeignKey("PBCASHTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBCashType? ThePBCashType { get; set; }

		[ForeignKey("PBILL4PAIDID")]
		public virtual Anu.PunishmentOrg.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PINSTALLMENTID")]
		public virtual Anu.PunishmentOrg.Execution.PInstallment? ThePInstallment { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("PBILL4PAIDREASON")]
    public partial class PBill4PaidReason : PBill4PaidReasonBase { }

    }


