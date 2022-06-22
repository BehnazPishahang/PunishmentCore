

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
{
    public abstract class PEnumerationWritUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PENUMERATIONWRITID")]
		public virtual Anu.PunishmentOrg.Proceeding.PEnumerationWrit? ThePEnumerationWrit { get; set; }

    }
    [Table("PENUMERATIONWRITUNIT")]
    public partial class PEnumerationWritUnit : PEnumerationWritUnitBase { }

    }


