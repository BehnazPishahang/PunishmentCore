

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBUnitAccountsBase : PunishmentOrgEntity<string>
    {

		[Column("ACCUNTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.AccountType? AccuntType { get; set; }

		[Column("CLIENTNUMBER")]
		public virtual string? ClientNumber { get; set; }

		[ForeignKey("ACCOUNTSID")]
		public virtual Anu.BaseInfo.Types.Accounts? TheAccounts { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBUNITACCOUNTS")]
    public partial class PBUnitAccounts : PBUnitAccountsBase { }

    }


