

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class AccountsBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNO")]
		public virtual string? AccountNo { get; set; }

		[Column("CLIENTNUMBER")]
		public virtual string? ClientNumber { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("IBAN")]
		public virtual string? IBAN { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TERMINALCODE")]
		public virtual string? TerminalCode { get; set; }

		[ForeignKey("BANKID")]
		public virtual Rad.BaseInfo.Finance.Bank? TheBank { get; set; }

		[ForeignKey("BANKBRANCHID")]
		public virtual Rad.BaseInfo.Finance.BankBranch? TheBankBranch { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("ACCOUNTS")]
    public partial class Accounts : AccountsBase { }

    }


