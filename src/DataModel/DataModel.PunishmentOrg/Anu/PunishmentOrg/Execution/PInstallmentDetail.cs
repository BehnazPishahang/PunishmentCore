

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PInstallmentDetailBase : PunishmentOrgEntity<string>
    {

		[Column("DUEDATE")]
		public virtual string? DueDate { get; set; }

		[Column("INSTALLMENTAMOUNT")]
		public virtual long? InstallmentAmount { get; set; }

		[Column("PAYAMOUNT")]
		public virtual long? PayAmount { get; set; }

		[Column("PAYDATE")]
		public virtual string? PayDate { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PINSTALLMENTID")]
		public virtual Anu.PunishmentOrg.Execution.PInstallment? ThePInstallment { get; set; }

		[InverseProperty("ThePInstallmentDetail")]
		public virtual List<Anu.PunishmentOrg.Accounting.PPaidReason>? ThePPaidReasonList { get; set; }

    }
    [Table("PINSTALLMENTDETAIL")]
    public partial class PInstallmentDetail : PInstallmentDetailBase { }

    }


