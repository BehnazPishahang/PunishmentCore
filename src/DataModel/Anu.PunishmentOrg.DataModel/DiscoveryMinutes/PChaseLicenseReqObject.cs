

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqObjectBase : PunishmentOrgEntity<string>
    {

        [Column("CONCLUSIONREQUEST")]
        public virtual Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

    }

    [Table("PCHASELICENSEREQOBJECT")]
    public partial class PChaseLicenseReqObject : PChaseLicenseReqObjectBase
    {
    }
    }