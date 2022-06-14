

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Accounting
{
    public abstract class PCashReasonBase : PunishmentOrgEntity<string>
    {

		[Column("BASEAMOUNT")]
		public virtual long? BaseAmount { get; set; }

		[Column("DEBTREDUCTIONVALUE")]
		public virtual long? DebtReductionValue { get; set; }

		[Column("DISCOUNTSTATE")]
		public virtual Anu.Enumerations.HaveNoHave? DiscountState { get; set; }

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

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PCASHID")]
		public virtual Anu.PunishmentOrg.Accounting.PCash? ThePCash { get; set; }

		[ForeignKey("PINSTALLMENTID")]
		public virtual Anu.PunishmentOrg.Execution.PInstallment? ThePInstallment { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("PCASHREASON")]
    public partial class PCashReason : PCashReasonBase { }

    }


