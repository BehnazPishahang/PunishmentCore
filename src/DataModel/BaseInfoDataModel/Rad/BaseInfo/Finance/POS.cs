

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class POSBase : BaseInfoEntity<string>
    {

		[Column("IP")]
		public virtual string? IP { get; set; }

		[Column("PC_MAC_ADDRESS")]
		public virtual string? PC_MAC_Address { get; set; }

		[Column("POSTYPE")]
		public virtual string? POSType { get; set; }

		[Column("SERIALNUMBER")]
		public virtual string? SerialNumber { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

    }
    [Table("POS")]
    public partial class POS : POSBase { }

    }


