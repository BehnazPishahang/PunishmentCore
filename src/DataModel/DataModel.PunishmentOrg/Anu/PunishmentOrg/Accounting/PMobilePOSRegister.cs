

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Accounting
{
    public abstract class PMobilePOSRegisterBase : PunishmentOrgEntity<string>
    {

		[Column("RECEIVERNO")]
		public virtual string? ReceiverNo { get; set; }

		[Column("TERMINALID")]
		public virtual string? TerminalID { get; set; }

		[ForeignKey("ACCOUNTSID")]
		public virtual Anu.BaseInfo.Types.Accounts? TheAccounts { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PMOBILEPOSREGISTER")]
    public partial class PMobilePOSRegister : PMobilePOSRegisterBase { }

    }


