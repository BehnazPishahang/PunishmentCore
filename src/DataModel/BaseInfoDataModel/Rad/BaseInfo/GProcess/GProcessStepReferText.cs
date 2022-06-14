

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepReferTextBase : BaseInfoEntity<string>
    {

		[Column("CAUSETEXT")]
		public virtual string? CauseText { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GPROCESSSTEPREFERTEXT")]
    public partial class GProcessStepReferText : GProcessStepReferTextBase { }

    }


