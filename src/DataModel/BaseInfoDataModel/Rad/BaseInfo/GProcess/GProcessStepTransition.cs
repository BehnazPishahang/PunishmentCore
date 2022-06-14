

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepTransitionBase : BaseInfoEntity<string>
    {

		[ForeignKey("CURRENTSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheCurrentStep { get; set; }

		[ForeignKey("GPROCESSID")]
		public virtual Rad.BaseInfo.GProcess.GProcess? TheGProcess { get; set; }

		[ForeignKey("GTRANSITIONCONTROLERID")]
		public virtual Rad.BaseInfo.GProcess.GTransitionControler? TheGTransitionControler { get; set; }

		[ForeignKey("NEXTSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheNextStep { get; set; }

		[Column("TRANSIOTIONTITLE")]
		public virtual string? TransiotionTitle { get; set; }

    }
    [Table("GPROCESSSTEPTRANSITION")]
    public partial class GProcessStepTransition : GProcessStepTransitionBase { }

    }


