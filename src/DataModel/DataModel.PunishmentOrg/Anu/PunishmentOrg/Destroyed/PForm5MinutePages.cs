

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PForm5MinutePagesBase : PunishmentOrgEntity<string>
    {

		[Column("FROMDATE")]
		public virtual string? FromDate { get; set; }

		[Column("LICENSEID")]
		public virtual string? LicenseID { get; set; }

		[Column("NUMPAGES")]
		public virtual long? NumPages { get; set; }

		[Column("PAGESTITLE")]
		public virtual string? PagesTitle { get; set; }

		[ForeignKey("PFORM5MINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PForm5Minute? ThePForm5Minute { get; set; }

		[Column("TODATE")]
		public virtual string? ToDate { get; set; }

    }
    [Table("PFORM5MINUTEPAGES")]
    public partial class PForm5MinutePages : PForm5MinutePagesBase { }

    }


