

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PPrisonerUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PPRISONERID")]
		public virtual Anu.PunishmentOrg.Execution.PPrisoner? ThePPrisoner { get; set; }

    }
    [Table("PPRISONERUNIT")]
    public partial class PPrisonerUnit : PPrisonerUnitBase { }

    }


