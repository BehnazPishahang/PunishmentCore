

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportInspectorBase : PunishmentOrgEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("INSPECTORCODE")]
		public virtual string? InspectorCode { get; set; }

		[Column("INSPECTORPOST")]
		public virtual Anu.Enumerations.PunishmentOrg.PUInspectorPost? InspectorPost { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("SYSTEMNAME")]
		public virtual string? SystemName { get; set; }

		[ForeignKey("PINSPECTIONREPORTID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReport? ThePInspectionReport { get; set; }

    }
    [Table("PINSPECTIONREPORTINSPECTOR")]
    public partial class PInspectionReportInspector : PInspectionReportInspectorBase { }

    }


