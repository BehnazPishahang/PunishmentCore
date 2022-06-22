

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedCaseBase : PunishmentOrgEntity<string>
    {

		[Column("CMSNO")]
		public virtual string? CMSNo { get; set; }

		[Column("CONFIRMDATETIME")]
		public virtual string? ConfirmDateTime { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESTROYEDNO")]
		public virtual string? DestroyedNo { get; set; }

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("ENDYEAR")]
		public virtual string? EndYear { get; set; }

		[Column("MANUALNO")]
		public virtual string? ManualNo { get; set; }

		[Column("PAGENUMBER")]
		public virtual long? PageNumber { get; set; }

		[Column("STEPNO")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DestroyedCaseStep? StepNo { get; set; }

		[ForeignKey("CONFIRMERID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheConfirmer { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PBOXFILEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PBoxFile? ThePBoxFile { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePDestroyedCase")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedCaseImages>? ThePDestroyedCaseImagesList { get; set; }

		[InverseProperty("ThePDestroyedCase")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedCaseOffending>? ThePDestroyedCaseOffendingList { get; set; }

		[InverseProperty("ThePDestroyedCase")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedCasePlaintiff>? ThePDestroyedCasePlaintiffList { get; set; }

		[InverseProperty("ThePDestroyedCase")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedCaseViolation>? ThePDestroyedCaseViolationList { get; set; }

		[InverseProperty("ThePDestroyedCase")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedJudge>? ThePDestroyedJudgeList { get; set; }

		[ForeignKey("REGISTRARID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegistrar { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PDESTROYEDCASE")]
    public partial class PDestroyedCase : PDestroyedCaseBase { }

    }


