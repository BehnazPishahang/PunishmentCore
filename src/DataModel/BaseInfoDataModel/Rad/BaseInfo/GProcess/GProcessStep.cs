

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepBase : BaseInfoEntity<string>
    {

		[Column("CHANGEATTACHMENTSPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeAttachmentsPermission { get; set; }

		[Column("CHANGELETTERSPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeLettersPermission { get; set; }

		[Column("CHANGEPAYMENTTRANSPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangePaymentTransPermission { get; set; }

		[Column("CHANGERELATEDDATAPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeRelatedDataPermission { get; set; }

		[Column("CHANGERELATEDPERSONPERMISSION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? ChangeRelatedPersonPermission { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ISFINALSTEP")]
		public virtual Rad.CMS.Enumerations.YesNo? IsFinalStep { get; set; }

		[Column("ISFIRSTSTEP")]
		public virtual Rad.CMS.Enumerations.YesNo? IsFirstStep { get; set; }

		[Column("ROWNO")]
		public virtual decimal? RowNo { get; set; }

		[Column("SENDSMSPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? SendSmsPermision { get; set; }

		[Column("SHOWSTOPREQUESTCOUSE")]
		public virtual Rad.CMS.Enumerations.YesNo? ShowStopRequestCouse { get; set; }

		[Column("SMSTEXT")]
		public virtual string? SmsText { get; set; }

		[Column("STOPREQUESTPERMISION")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? StopRequestPermision { get; set; }

		[ForeignKey("GPROCESSID")]
		public virtual Rad.BaseInfo.GProcess.GProcess? TheGProcess { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepArgument>? TheGProcessStepArgumentList { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepBankAccount>? TheGProcessStepBankAccountList { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepReferRole>? TheGProcessStepReferRoleList { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepReferText>? TheGProcessStepReferTextList { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepReferUser>? TheGProcessStepReferUserList { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GProseccStepAndGroupRelation>? TheGProseccStepAndGroupRelationList { get; set; }

		[InverseProperty("TheGProcessStep")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestAction>? TheGRequestActionList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GPROCESSSTEP")]
    public partial class GProcessStep : GProcessStepBase { }

    }


