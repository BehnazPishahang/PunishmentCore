

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
{
    public abstract class PProceedingMinuteUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PPROCEEDINGMINUTEID")]
		public virtual Anu.PunishmentOrg.Proceeding.PProceedingMinute? ThePProceedingMinute { get; set; }

    }
    [Table("PPROCEEDINGMINUTEUNIT")]
    public partial class PProceedingMinuteUnit : PProceedingMinuteUnitBase { }

    }


