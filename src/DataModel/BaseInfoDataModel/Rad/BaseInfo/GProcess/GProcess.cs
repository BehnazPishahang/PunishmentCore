

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DEFAULTALERTTIME")]
		public virtual decimal? DefaultAlertTime { get; set; }

		[Column("DEFAULTEXECUTIONTIME")]
		public virtual decimal? DefaultExecutionTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("RELATEDSYSTEM")]
		public virtual Rad.CMS.Enumerations.Subsystems? RelatedSystem { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGProcess")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessAlertingSetting>? TheGProcessAlertingSettingList { get; set; }

		[InverseProperty("TheGProcess")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessAttachmentType>? TheGProcessAttachmentTypeList { get; set; }

		[InverseProperty("TheGProcess")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessEditRoles>? TheGProcessEditRolesList { get; set; }

		[InverseProperty("TheGProcess")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStep>? TheGProcessStepList { get; set; }

		[InverseProperty("TheGProcess")]
		public virtual List<Rad.BaseInfo.GProcess.GProcessStepTransition>? TheGProcessStepTransitionList { get; set; }

		[InverseProperty("TheGProcess")]
		public virtual List<Rad.BaseInfo.GProcess.GRequest>? TheGRequestList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GPROCESS")]
    public partial class GProcess : GProcessBase { }

    }


