using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class AccountsBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ACCOUNTNO")]
        public virtual string? AccountNo { get; set; }

        [Unicode(false)]
        [Column("CLIENTNUMBER")]
        public virtual string? ClientNumber { get; set; }

        [Unicode(false)]
        [Column("IBAN")]
        public virtual string? IBAN { get; set; }

        [Unicode(false)]
        [Column("IBANORDER")]
        public virtual string? IBANOrder { get; set; }

        [Column("ISTREASURYCONSTANT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsTreasuryConstant { get; set; }

        [Unicode(false)]
        [Column("OWNERDESCRIPTION")]
        public virtual string? OwnerDescription { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("BANKID")]
        public virtual Anu.BaseInfo.DataModel.Types.Bank? TheBank { get; set; }

        [ForeignKey("GACCOUNTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GAccountType? TheGAccountType { get; set; }

        [Unicode(false)]
        [Column("TREASURYID")]
        public virtual string? TreasuryID { get; set; }

        }

    [Table("ACCOUNTS")]
    public partial class Accounts : AccountsBase
    {
    }
    }