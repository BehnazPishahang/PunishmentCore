

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PPrisonerBase : PunishmentOrgEntity<string>
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

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePPrisoner")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPrisonerBindingSubject>? ThePPrisonerBindingSubjectList { get; set; }

        [InverseProperty("ThePPrisoner")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPrisonerLeave>? ThePPrisonerLeaveList { get; set; }

        [InverseProperty("ThePPrisoner")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PPrisonerUnit>? ThePPrisonerUnitList { get; set; }

        [ForeignKey("PRISONID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? ThePrison { get; set; }

        [ForeignKey("PRISONPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePrisonPerson { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PPRISONER")]
    public partial class PPrisoner : PPrisonerBase
    {
    }
    }