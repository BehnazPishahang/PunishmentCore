

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PCancelSaftyWritIssuerBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCANCELSAFTYWRITID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PCancelSaftyWrit? ThePCancelSaftyWrit { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PCANCELSAFTYWRITISSUER")]
    public partial class PCancelSaftyWritIssuer : PCancelSaftyWritIssuerBase { }

    }


