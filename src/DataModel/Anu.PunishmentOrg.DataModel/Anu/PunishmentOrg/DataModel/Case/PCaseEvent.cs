

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseEventBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("EVENTABSTRACT")]
        public virtual string? EventAbstract { get; set; }

        [Column("EVENTDATE")]
        public virtual string? EventDate { get; set; }

        [Column("HOWTOMAKEEVENT")]
        public virtual Anu.BaseInfo.Enumerations.HowToMakeEvent? HowToMakeEvent { get; set; }

        [Column("ISCASEPERSONSEE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsCasePersonSee { get; set; }

        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocId { get; set; }

        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PBCASEEVENTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBCaseEventType? ThePBCaseEventType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

    }

    [Table("PCASEEVENT")]
    public partial class PCaseEvent : PCaseEventBase
    {
    }
}