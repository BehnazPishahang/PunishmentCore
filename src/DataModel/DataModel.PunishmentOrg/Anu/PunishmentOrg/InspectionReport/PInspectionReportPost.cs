

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.InspectionReport
{
    public abstract class PInspectionReportPostBase : PunishmentOrgEntity<string>
    {

		[Column("POSTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PSuspectPostType? PostType { get; set; }

		[ForeignKey("PINSPECTIONREPORTDIRECTORSID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PInspectionReportDirectors? ThePInspectionReportDirectors { get; set; }

    }
    [Table("PINSPECTIONREPORTPOST")]
    public partial class PInspectionReportPost : PInspectionReportPostBase { }

    }


