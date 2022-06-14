

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class GCurrentServerBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[ForeignKey("CURCMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCurCMSOrganization { get; set; }

		[ForeignKey("CURSERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCurServer { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GCURRENTSERVER")]
    public partial class GCurrentServer : GCurrentServerBase { }

    }


