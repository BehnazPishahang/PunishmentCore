

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PPrisonerBase : PunishmentOrgEntity<string>
    {

		[Column("CONFIRMERPOSTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("FREEDATE")]
		public virtual string? FreeDate { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NUMDAYREMAIN")]
		public virtual long? NumDayRemain { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePPrisoner")]
		public virtual List<Anu.PunishmentOrg.Execution.PPrisonerBindingSubject>? ThePPrisonerBindingSubjectList { get; set; }

		[InverseProperty("ThePPrisoner")]
		public virtual List<Anu.PunishmentOrg.Execution.PPrisonerLeave>? ThePPrisonerLeaveList { get; set; }

		[InverseProperty("ThePPrisoner")]
		public virtual List<Anu.PunishmentOrg.Execution.PPrisonerUnit>? ThePPrisonerUnitList { get; set; }

		[ForeignKey("PRISONID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? ThePrison { get; set; }

		[ForeignKey("PRISONPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePrisonPerson { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PPRISONER")]
    public partial class PPrisoner : PPrisonerBase { }

    }


