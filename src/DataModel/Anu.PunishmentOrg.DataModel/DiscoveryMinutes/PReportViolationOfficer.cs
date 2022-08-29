using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PReportViolationOfficerBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("DEGREE")]
        public virtual string? Degree { get; set; }

        [Unicode(false)]
        [Column("DISCOVERYUNIT")]
        public virtual string? DiscoveryUnit { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONCODE")]
        public virtual string? InspectionCode { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Unicode(false)]
        [Column("PERSONELNO")]
        public virtual string? PersonelNo { get; set; }

        [Unicode(false)]
        [Column("SIGNTEXT")]
        public virtual string? SignText { get; set; }

        [Unicode(false)]
        [Column("SYSTEMNAME")]
        public virtual string? SystemName { get; set; }

        [ForeignKey("PREPORTVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

        }

    [Table("PREPORTVIOLATIONOFFICER")]
    public partial class PReportViolationOfficer : PReportViolationOfficerBase
    {
    }
    }