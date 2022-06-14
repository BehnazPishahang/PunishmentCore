

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportRetReasonBase : PunishmentOrgEntity<string>
    {

		[Column("RETURNREASON")]
		public virtual Anu.Enumerations.PunishmentOrg.InspectionReportReturnReason? ReturnReason { get; set; }

		[ForeignKey("PINSPECTIONREPORTID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    }
    [Table("PINSPECTIONREPORTRETREASON")]
    public partial class PInspectionReportRetReason : PInspectionReportRetReasonBase { }

    }


