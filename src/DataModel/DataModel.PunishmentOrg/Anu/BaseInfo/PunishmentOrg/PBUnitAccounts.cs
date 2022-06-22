

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBUnitAccountsBase : PunishmentOrgEntity<string>
    {

		[Column("ACCUNTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.AccountType? AccuntType { get; set; }

		[Column("CLIENTNUMBER")]
		public virtual string? ClientNumber { get; set; }

		[ForeignKey("ACCOUNTSID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.Accounts? TheAccounts { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBUNITACCOUNTS")]
    public partial class PBUnitAccounts : PBUnitAccountsBase { }

    }


