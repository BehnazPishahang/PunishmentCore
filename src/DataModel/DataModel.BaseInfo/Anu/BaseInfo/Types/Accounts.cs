

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Types
{
    public abstract class AccountsBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNO")]
		public virtual string? AccountNo { get; set; }

		[Column("CLIENTNUMBER")]
		public virtual string? ClientNumber { get; set; }

		[Column("IBAN")]
		public virtual string? IBAN { get; set; }

		[Column("IBANORDER")]
		public virtual string? IBANOrder { get; set; }

		[Column("ISTREASURYCONSTANT")]
		public virtual Anu.Enumerations.YesNo? IsTreasuryConstant { get; set; }

		[Column("OWNERDESCRIPTION")]
		public virtual string? OwnerDescription { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("BANKID")]
		public virtual Anu.BaseInfo.Types.Bank? TheBank { get; set; }

		[ForeignKey("GACCOUNTTYPEID")]
		public virtual Anu.BaseInfo.Types.GAccountType? TheGAccountType { get; set; }

		[Column("TREASURYID")]
		public virtual string? TreasuryID { get; set; }

    }
    [Table("ACCOUNTS")]
    public partial class Accounts : AccountsBase { }

    }


