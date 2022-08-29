using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Attachment
{
    public abstract class GTransactionAsyncBase : BaseInfoEntity<string>
    {

        [Column("ASYNCTYPE")]
        public virtual Anu.BaseInfo.Enumerations.AsyncType? AsyncType { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DBTRANSACTIONID")]
        public virtual string? DBTransactionId { get; set; }

        [Unicode(false)]
        [Column("ECMTRANSACTIONID")]
        public virtual string? ECMTransactionId { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

        [ForeignKey("CMSUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

        [ForeignKey("ECMSERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.ECMServer? TheECMServer { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        }

    [Table("GTRANSACTIONASYNC")]
    public partial class GTransactionAsync : GTransactionAsyncBase
    {
    }
    }