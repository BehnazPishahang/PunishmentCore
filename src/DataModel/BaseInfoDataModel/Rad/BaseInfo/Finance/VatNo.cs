

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class VatNoBase : BaseInfoEntity<string>
    {

		[Column("NO")]
		public virtual string? No { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[Column("YEAR")]
		public virtual string? Year { get; set; }

    }
    [Table("VATNO")]
    public partial class VatNo : VatNoBase { }

    }


