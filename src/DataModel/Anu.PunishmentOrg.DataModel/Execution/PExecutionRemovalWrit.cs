using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PExecutionRemovalWritBase : PunishmentOrgEntity<string>
    {

        [Column("CONFIRMERPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("JUDNO")]
        public virtual string? JudNo { get; set; }

        [Unicode(false)]
        [Column("MANUALNO")]
        public virtual string? ManualNo { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("PASSPORTOFFICERDESC")]
        public virtual string? PAssportOfficerDesc { get; set; }

        [Unicode(false)]
        [Column("PROSECUTORREJECTREASON")]
        public virtual string? ProsecutorRejectReason { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PEXECUTIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Unicode(false)]
        [Column("WRITTEXT")]
        public virtual string? WritText { get; set; }

        [Column("WRITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUExecutionWritType? WritType { get; set; }

        }

    [Table("PEXECUTIONREMOVALWRIT")]
    public partial class PExecutionRemovalWrit : PExecutionRemovalWritBase
    {
    }
    }