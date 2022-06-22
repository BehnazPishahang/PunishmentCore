

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Attachment
{
    public abstract class GTransactionAsyncBase : BaseInfoEntity<string>
    {

		[Column("ASYNCTYPE")]
		public virtual Anu.Enumerations.AsyncType? AsyncType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DBTRANSACTIONID")]
		public virtual string? DBTransactionId { get; set; }

		[Column("ECMTRANSACTIONID")]
		public virtual string? ECMTransactionId { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("ECMSERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.ECMServer? TheECMServer { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GTRANSACTIONASYNC")]
    public partial class GTransactionAsync : GTransactionAsyncBase { }

    }


