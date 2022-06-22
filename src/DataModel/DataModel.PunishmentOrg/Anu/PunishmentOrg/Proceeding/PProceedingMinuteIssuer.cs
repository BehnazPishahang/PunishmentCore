

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
{
    public abstract class PProceedingMinuteIssuerBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PPROCEEDINGMINUTEID")]
		public virtual Anu.PunishmentOrg.Proceeding.PProceedingMinute? ThePProceedingMinute { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PPROCEEDINGMINUTEISSUER")]
    public partial class PProceedingMinuteIssuer : PProceedingMinuteIssuerBase { }

    }


