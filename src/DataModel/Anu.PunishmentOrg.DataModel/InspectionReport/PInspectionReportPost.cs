using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportPostBase : PunishmentOrgEntity<string>
    {

        [Column("POSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PSuspectPostType? PostType { get; set; }

        [ForeignKey("PINSPECTIONREPORTDIRECTORSID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportDirectors? ThePInspectionReportDirectors { get; set; }

        }

    [Table("PINSPECTIONREPORTPOST")]
    public partial class PInspectionReportPost : PInspectionReportPostBase
    {
    }
    }