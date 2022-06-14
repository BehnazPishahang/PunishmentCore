

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaRevokeReqBase : BaseInfoEntity<string>
    {

		[Column("REQDATETIME")]
		public virtual string? ReqDateTime { get; set; }

		[Column("REQNO")]
		public virtual string? ReqNo { get; set; }

		[Column("REVOKEREQREASON")]
		public virtual Rad.CMS.Enumerations.PkiRaReasonType? RevokeReqReason { get; set; }

		[Column("REVOKERSIGN")]
		public virtual string? RevokerSign { get; set; }

		[InverseProperty("ThePkiRaRevokeReq")]
		public virtual List<Rad.BaseInfo.Pki.RA.PkiRaCertificates>? ThePkiRaCertificatesList { get; set; }

		[ForeignKey("REQUESTERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheRequester { get; set; }

		[ForeignKey("REVOKERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheRevoker { get; set; }

    }
    [Table("PKIRAREVOKEREQ")]
    public partial class PkiRaRevokeReq : PkiRaRevokeReqBase { }

    }


