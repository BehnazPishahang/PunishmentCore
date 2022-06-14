

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Types
{
    public abstract class BankBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheBank")]
		public virtual List<Anu.BaseInfo.Types.Accounts>? TheAccountsList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("BANK")]
    public partial class Bank : BankBase { }

    }


