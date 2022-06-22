

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PReportViolationAttachBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PREPORTVIOLATIONID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

    }
    [Table("PREPORTVIOLATIONATTACH")]
    public partial class PReportViolationAttach : PReportViolationAttachBase { }

    }


