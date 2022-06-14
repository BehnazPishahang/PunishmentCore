

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessAlertingSettingBase : BaseInfoEntity<string>
    {

		[Column("ALERTTIME")]
		public virtual decimal? AlertTime { get; set; }

		[Column("EXECUTIONTIME")]
		public virtual decimal? ExecutionTime { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GPROCESSID")]
		public virtual Rad.BaseInfo.GProcess.GProcess? TheGProcess { get; set; }

    }
    [Table("GPROCESSALERTINGSETTING")]
    public partial class GProcessAlertingSetting : GProcessAlertingSettingBase { }

    }


