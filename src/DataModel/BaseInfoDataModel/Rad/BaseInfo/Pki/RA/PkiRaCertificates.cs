

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaCertificatesBase : BaseInfoEntity<string>
    {

		[Column("CMSUSERID")]
		public virtual string? CMSUserId { get; set; }

		[Column("DN")]
		public virtual string? DN { get; set; }

		[Column("EMPLOYEEID")]
		public virtual string? EmployeeID { get; set; }

		[Column("FROMDATE")]
		public virtual string? FromDate { get; set; }

		[Column("RAWDATA")]
		public virtual byte[]? RawData { get; set; }

		[Column("SERIALNO")]
		public virtual string? SerialNo { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.PkiRaCertificateState? State { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("PKIRACERTIFICATETYPEID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaCertificateType? ThePkiRaCertificateType { get; set; }

		[InverseProperty("ThePkiRaCertificates")]
		public virtual List<Rad.BaseInfo.Pki.RA.PkiRaCertRegUsrHst>? ThePkiRaCertRegUsrHstList { get; set; }

		[ForeignKey("PKIRAREQID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaReq? ThePkiRaReq { get; set; }

		[ForeignKey("PKIRAREVOKEREQID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaRevokeReq? ThePkiRaRevokeReq { get; set; }

		[Column("TODATE")]
		public virtual string? ToDate { get; set; }

		[Column("TOKENBRAND")]
		public virtual string? TokenBrand { get; set; }

    }
    [Table("PKIRACERTIFICATES")]
    public partial class PkiRaCertificates : PkiRaCertificatesBase { }

    }


