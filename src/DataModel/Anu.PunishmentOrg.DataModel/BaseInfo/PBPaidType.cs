

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBPaidTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("RELATEDFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedForm { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBPAIDTYPE")]
    public partial class PBPaidType : PBPaidTypeBase
    {
    }
}