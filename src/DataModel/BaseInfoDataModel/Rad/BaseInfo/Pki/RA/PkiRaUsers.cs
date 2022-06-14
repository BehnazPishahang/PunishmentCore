

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaUsersBase : BaseInfoEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("PKIRAUSERS")]
    public partial class PkiRaUsers : PkiRaUsersBase { }

    }


