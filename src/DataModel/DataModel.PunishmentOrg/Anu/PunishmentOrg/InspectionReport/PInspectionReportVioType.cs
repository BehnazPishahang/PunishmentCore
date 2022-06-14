

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportVioTypeBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBINSPECTIONVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBInspectionViolationType? ThePBInspectionViolationType { get; set; }

		[ForeignKey("PINSPECTIONREPORTVIOLATIONID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReportViolation? ThePInspectionReportViolation { get; set; }

    }
    [Table("PINSPECTIONREPORTVIOTYPE")]
    public partial class PInspectionReportVioType : PInspectionReportVioTypeBase { }

    }


