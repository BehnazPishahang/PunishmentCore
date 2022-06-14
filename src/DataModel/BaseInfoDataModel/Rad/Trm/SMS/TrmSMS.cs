

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Trm.SMS
{
    public abstract class TrmSMSBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DOCID")]
		public virtual string? DocId { get; set; }

		[Column("DOCNO")]
		public virtual string? DocNo { get; set; }

		[Column("MOBILENUMBER4SMS")]
		public virtual string? MobileNumber4SMS { get; set; }

		[Column("RECEIVERNAME")]
		public virtual string? ReceiverName { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RESPONSEDATETIME")]
		public virtual string? ResponseDateTime { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SMSID")]
		public virtual string? SMSID { get; set; }

		[Column("SMSSTATUS")]
		public virtual Rad.CMS.Enumerations.CMSSMSStatus? SMSStatus { get; set; }

		[Column("SMSTEXT")]
		public virtual string? SMSText { get; set; }

		[ForeignKey("CREATEDORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCreatedOrg { get; set; }

		[ForeignKey("CREATEDSERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCreatedServer { get; set; }

		[ForeignKey("TRMSMSID")]
		public virtual List<Rad.Trm.SMS.TrmSMSNotSend>? TheTrmSMSNotSendList { get; set; }

    }
    [Table("TRMSMS")]
    public partial class TrmSMS : TrmSMSBase { }

    }


