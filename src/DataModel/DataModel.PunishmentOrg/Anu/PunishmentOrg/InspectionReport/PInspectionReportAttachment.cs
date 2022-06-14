

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportAttachmentBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PINSPECTIONREPORTID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    }
    [Table("PINSPECTIONREPORTATTACHMENT")]
    public partial class PInspectionReportAttachment : PInspectionReportAttachmentBase { }

    }


