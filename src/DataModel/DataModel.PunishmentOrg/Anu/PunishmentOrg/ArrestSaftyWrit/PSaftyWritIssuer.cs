

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PSaftyWritIssuerBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PSAFTYWRITID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWrit? ThePSaftyWrit { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PSAFTYWRITISSUER")]
    public partial class PSaftyWritIssuer : PSaftyWritIssuerBase { }

    }


