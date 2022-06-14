

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PinspectionReportTradeBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBTRADEUNITTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBTradeUnitType? ThePBTradeUnitType { get; set; }

		[ForeignKey("PINSPECTIONREPORTID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    }
    [Table("PINSPECTIONREPORTTRADE")]
    public partial class PinspectionReportTrade : PinspectionReportTradeBase { }

    }


