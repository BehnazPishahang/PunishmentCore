using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsTUAttachmentBase : PunishmentOrgEntity<string>
    {

        [Column("DOCFILE")]
        public virtual byte[]? DocFile { get; set; }

        [Unicode(false)]
        [Column("ID")]
        public virtual string? Id { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PMOBILEPATROLSTRADEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTradeUnit? ThePMobilePatrolsTradeUnit { get; set; }

        }

    [Table("PMOBILEPATROLSTUATTACHMENT")]
    public partial class PMobilePatrolsTUAttachment : PMobilePatrolsTUAttachmentBase
    {
    }
    }