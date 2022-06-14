

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class PostRegionOrganizationBase : BaseInfoEntity<string>
    {

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("POSTREGIONID")]
		public virtual Rad.BaseInfo.Finance.PostRegion? ThePostRegion { get; set; }

    }
    [Table("POSTREGIONORGANIZATION")]
    public partial class PostRegionOrganization : PostRegionOrganizationBase { }

    }


