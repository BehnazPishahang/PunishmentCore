

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepBankAccountBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNUMBER")]
		public virtual string? AccountNumber { get; set; }

		[Column("ACCOUNTTITLE")]
		public virtual string? AccountTitle { get; set; }

		[Column("ACCOUNTTYPE")]
		public virtual string? AccountType { get; set; }

		[Column("BANKNAME")]
		public virtual string? BankName { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

		[InverseProperty("TheGProcessStepBankAccount")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestPayment>? TheGRequestPaymentList { get; set; }

    }
    [Table("GPROCESSSTEPBANKACCOUNT")]
    public partial class GProcessStepBankAccount : GProcessStepBankAccountBase { }

    }


