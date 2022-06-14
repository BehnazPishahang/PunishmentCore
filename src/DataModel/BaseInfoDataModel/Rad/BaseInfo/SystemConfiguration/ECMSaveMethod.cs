

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class ECMSaveMethodBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("SAVEATTACHMENTTYPE")]
		public virtual Rad.CMS.Enumerations.SaveAttachmentType? SaveAttachmentType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.Subsystems? State { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("ECMSERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.ECMServer? TheECMServer { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("ECMSAVEMETHOD")]
    public partial class ECMSaveMethod : ECMSaveMethodBase { }

    }


