

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBUnitAccountsBase : PunishmentOrgEntity<string>
    {

        [Column("ACCUNTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.AccountType? AccuntType { get; set; }

        [Column("CLIENTNUMBER")]
        public virtual string? ClientNumber { get; set; }

        [ForeignKey("ACCOUNTSID")]
        public virtual Anu.BaseInfo.DataModel.Types.Accounts? TheAccounts { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PBUNITACCOUNTS")]
    public partial class PBUnitAccounts : PBUnitAccountsBase
    {
    }
}