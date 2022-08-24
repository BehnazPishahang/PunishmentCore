using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeDefectBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("DEFECTTITLE")]
        public virtual string? DefectTitle { get; set; }

        [ForeignKey("PBDEFECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBDefectType? ThePBDefectType { get; set; }

        [ForeignKey("PNOTICEID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNotice? ThePNotice { get; set; }

        }

    [Table("PNOTICEDEFECT")]
    public partial class PNoticeDefect : PNoticeDefectBase
    {
    }
    }