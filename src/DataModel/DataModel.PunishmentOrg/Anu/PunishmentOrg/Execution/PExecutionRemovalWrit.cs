

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PExecutionRemovalWritBase : PunishmentOrgEntity<string>
    {

		[Column("CONFIRMERPOSTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("JUDNO")]
		public virtual string? JudNo { get; set; }

		[Column("MANUALNO")]
		public virtual string? ManualNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PASSPORTOFFICERDESC")]
		public virtual string? PAssportOfficerDesc { get; set; }

		[Column("PROSECUTORREJECTREASON")]
		public virtual string? ProsecutorRejectReason { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PEXECUTIONWRITID")]
		public virtual Anu.PunishmentOrg.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("WRITTEXT")]
		public virtual string? WritText { get; set; }

		[Column("WRITTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUExecutionWritType? WritType { get; set; }

    }
    [Table("PEXECUTIONREMOVALWRIT")]
    public partial class PExecutionRemovalWrit : PExecutionRemovalWritBase { }

    }


