

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class BankBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheBank")]
        public virtual List<Anu.BaseInfo.DataModel.Types.Accounts>? TheAccountsList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("BANK")]
    public partial class Bank : BankBase
    {
    }
    }