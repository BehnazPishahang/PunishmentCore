

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.ExchangeData
{
    public abstract class MocLogBase : BaseInfoEntity<string>
    {

		[Column("ACTIONDATETIME")]
		public virtual string? ActionDateTime { get; set; }

		[Column("ACTIONNAME")]
		public virtual string? ActionName { get; set; }

		[Column("ACTIONRESULTS")]
		public virtual string? ActionResults { get; set; }

		[Column("ACTIONTYPE")]
		public virtual string? ActionType { get; set; }

		[Column("ERRORCODE")]
		public virtual string? ErrorCode { get; set; }

		[Column("ERRORTEXT")]
		public virtual string? ErrorText { get; set; }

		[Column("FACEIMAGE")]
		public virtual byte[]? FaceImage { get; set; }

		[Column("FINGERTYPE")]
		public virtual Rad.CMS.Enumerations.Finger? FingerType { get; set; }

		[Column("ILM")]
		public virtual decimal? ILM { get; set; }

		[Column("NATIONALNO")]
		public virtual string? NationalNo { get; set; }

		[Column("OTHERINFORMATION")]
		public virtual string? OtherInformation { get; set; }

		[Column("RECIEVEDPACKET")]
		public virtual string? RecievedPacket { get; set; }

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocId { get; set; }

		[Column("RELATEDFINGERPRINTLOGID")]
		public virtual string? RelatedFingerprintLogId { get; set; }

		[Column("SENTPACKET")]
		public virtual string? SentPacket { get; set; }

		[Column("SERIALNO")]
		public virtual decimal? SerialNo { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

    }
    [Table("MOCLOG")]
    public partial class MocLog : MocLogBase { }

    }


