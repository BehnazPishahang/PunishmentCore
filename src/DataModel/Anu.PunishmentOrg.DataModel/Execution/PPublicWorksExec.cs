using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPublicWorksExecBase : PunishmentOrgEntity<string>
    {

        [Column("CONFIRMERPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("FREEDATE")]
        public virtual string? FreeDate { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("NUMDAYREMAIN")]
        public virtual long? NumDayRemain { get; set; }

        [Column("PRESENCE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUPublicWorkTime? Presence { get; set; }

        [Unicode(false)]
        [Column("PUBLICWORKNAME")]
        public virtual string? PublicWorkName { get; set; }

        [Unicode(false)]
        [Column("PUBLICWORKPLACEADDRESS")]
        public virtual string? PublicWorkPlaceAddress { get; set; }

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBPUBLICWORKPLACETYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBPublicWorkPlaceType? ThePBPublicWorkPlaceType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [InverseProperty("ThePPublicWorksExec")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExecBindingSubj>? ThePPublicWorksExecBindingSubjList { get; set; }

        [InverseProperty("ThePPublicWorksExec")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPublicWorksExecUnit>? ThePPublicWorksExecUnitList { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("WORKTIMECOUNT")]
        public virtual long? WorkTimeCount { get; set; }

        }

    [Table("PPUBLICWORKSEXEC")]
    public partial class PPublicWorksExec : PPublicWorksExecBase
    {
    }
    }