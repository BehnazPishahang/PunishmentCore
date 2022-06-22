

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqObjectBase : PunishmentOrgEntity<string>
    {

		[Column("CONCLUSIONREQUEST")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUConclusion? ConclusionRequest { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

    }
    [Table("PCHASELICENSEREQOBJECT")]
    public partial class PChaseLicenseReqObject : PChaseLicenseReqObjectBase { }

    }


