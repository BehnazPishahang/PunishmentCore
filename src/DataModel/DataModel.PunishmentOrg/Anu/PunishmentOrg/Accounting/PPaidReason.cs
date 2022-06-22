

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PPaidReasonBase : PunishmentOrgEntity<string>
    {

		[Column("OLDCASEBINDINGIDS")]
		public virtual string? OldCaseBindingIDs { get; set; }

		[Column("PAIDCOST")]
		public virtual long? PaidCost { get; set; }

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocId { get; set; }

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[ForeignKey("PBPAIDTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBPaidType? ThePBPaidType { get; set; }

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PINSTALLMENTDETAILID")]
		public virtual Anu.PunishmentOrg.Execution.PInstallmentDetail? ThePInstallmentDetail { get; set; }

		[ForeignKey("PPAIDID")]
		public virtual Anu.PunishmentOrg.Accounting.PPaid? ThePPaid { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("PPAIDREASON")]
    public partial class PPaidReason : PPaidReasonBase { }

    }


