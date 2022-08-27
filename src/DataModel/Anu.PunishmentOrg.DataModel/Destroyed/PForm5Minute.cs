using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PForm5MinuteBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ARCHIVEADDRESS")]
        public virtual string? ArchiveAddress { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("FREEAREA")]
        public virtual long? FreeArea { get; set; }

        [Unicode(false)]
        [Column("ISSUEDATE")]
        public virtual string? IssueDate { get; set; }

        [Unicode(false)]
        [Column("LETTERDATE")]
        public virtual string? LetterDate { get; set; }

        [Unicode(false)]
        [Column("LETTERNO")]
        public virtual string? LetterNo { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("PAGESUM")]
        public virtual long? PageSum { get; set; }

        [ForeignKey("PDESTROYEDLICENSEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

        [InverseProperty("ThePForm5Minute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PForm5MinuteConfirmer>? ThePForm5MinuteConfirmerList { get; set; }

        [InverseProperty("ThePForm5Minute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PForm5MinuteImages>? ThePForm5MinuteImagesList { get; set; }

        [InverseProperty("ThePForm5Minute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PForm5MinutePages>? ThePForm5MinutePagesList { get; set; }

        [ForeignKey("REGISTRARUSERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegistrarUser { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("PFORM5MINUTE")]
    public partial class PForm5Minute : PForm5MinuteBase
    {
    }
    }