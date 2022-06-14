

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaProcessLoggingBase : BaseInfoEntity<string>
    {

		[Column("CLIENTIP")]
		public virtual string? ClientIP { get; set; }

		[Column("ENDDATETIME")]
		public virtual string? EndDateTime { get; set; }

		[Column("ISOUTOFBROWSER")]
		public virtual Rad.CMS.Enumerations.YesNo? IsOutOfBrowser { get; set; }

		[Column("ISSUCCESSFUL")]
		public virtual Rad.CMS.Enumerations.YesNo? IsSuccessful { get; set; }

		[Column("OCXVERSION")]
		public virtual string? OcxVersion { get; set; }

		[Column("OS")]
		public virtual string? OS { get; set; }

		[Column("PROCESSKEY")]
		public virtual string? ProcessKey { get; set; }

		[Column("PROCESSXML")]
		public virtual string? ProcessXML { get; set; }

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[InverseProperty("ThePkiRaProcessLogging")]
		public virtual List<Rad.BaseInfo.Pki.RA.PkiRaLogging>? ThePkiRaLoggingList { get; set; }

		[ForeignKey("PKIRAREQID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaReq? ThePkiRaReq { get; set; }

    }
    [Table("PKIRAPROCESSLOGGING")]
    public partial class PkiRaProcessLogging : PkiRaProcessLoggingBase { }

    }


