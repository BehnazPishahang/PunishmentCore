

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PReportViolationAttachBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PREPORTVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

    }

    [Table("PREPORTVIOLATIONATTACH")]
    public partial class PReportViolationAttach : PReportViolationAttachBase
    {
    }
    }