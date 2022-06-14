

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PPublicWorksExecBase : PunishmentOrgEntity<string>
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

		[Column("PRESENCE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUPublicWorkTime? Presence { get; set; }

		[Column("PUBLICWORKNAME")]
		public virtual string? PublicWorkName { get; set; }

		[Column("PUBLICWORKPLACEADDRESS")]
		public virtual string? PublicWorkPlaceAddress { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBPUBLICWORKPLACETYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBPublicWorkPlaceType? ThePBPublicWorkPlaceType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[InverseProperty("ThePPublicWorksExec")]
		public virtual List<Anu.PunishmentOrg.Execution.PPublicWorksExecBindingSubj>? ThePPublicWorksExecBindingSubjList { get; set; }

		[InverseProperty("ThePPublicWorksExec")]
		public virtual List<Anu.PunishmentOrg.Execution.PPublicWorksExecUnit>? ThePPublicWorksExecUnitList { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("WORKTIMECOUNT")]
		public virtual long? WorkTimeCount { get; set; }

    }
    [Table("PPUBLICWORKSEXEC")]
    public partial class PPublicWorksExec : PPublicWorksExecBase { }

    }


