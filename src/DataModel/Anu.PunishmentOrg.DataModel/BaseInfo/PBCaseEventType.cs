

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBCaseEventTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBCASEEVENTTYPE")]
    public partial class PBCaseEventType : PBCaseEventTypeBase
    {
    }
}