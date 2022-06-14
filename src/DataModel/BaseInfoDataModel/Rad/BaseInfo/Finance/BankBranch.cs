

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class BankBranchBase : BaseInfoEntity<string>
    {

		[Column("BRANCHCODE")]
		public virtual string? BranchCode { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("BANKID")]
		public virtual Rad.BaseInfo.Finance.Bank? TheBank { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("BANKBRANCH")]
    public partial class BankBranch : BankBranchBase { }

    }


