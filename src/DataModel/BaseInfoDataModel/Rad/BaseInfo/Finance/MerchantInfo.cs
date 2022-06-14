

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class MerchantInfoBase : BaseInfoEntity<string>
    {

		[Column("INTERNETTERMINALID")]
		public virtual string? InternetTerminalID { get; set; }

		[Column("IP")]
		public virtual string? IP { get; set; }

		[Column("MERCHANTID")]
		public virtual string? MerchantID { get; set; }

		[Column("POSTYPE")]
		public virtual string? POSType { get; set; }

		[Column("SERIALNO")]
		public virtual string? SerialNo { get; set; }

		[Column("TERMINALID")]
		public virtual string? TerminalID { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

    }
    [Table("MERCHANTINFO")]
    public partial class MerchantInfo : MerchantInfoBase { }

    }


