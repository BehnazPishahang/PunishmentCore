

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PForm5MinutePagesBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATE")]
        public virtual string? FromDate { get; set; }

        [Unicode(false)]
        [Column("LICENSEID")]
        public virtual string? LicenseID { get; set; }

        [Column("NUMPAGES")]
        public virtual long? NumPages { get; set; }

        [Unicode(false)]
        [Column("PAGESTITLE")]
        public virtual string? PagesTitle { get; set; }

        [ForeignKey("PFORM5MINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PForm5Minute? ThePForm5Minute { get; set; }

        [Unicode(false)]
        [Column("TODATE")]
        public virtual string? ToDate { get; set; }

    }

    [Table("PFORM5MINUTEPAGES")]
    public partial class PForm5MinutePages : PForm5MinutePagesBase
    {
    }
    }