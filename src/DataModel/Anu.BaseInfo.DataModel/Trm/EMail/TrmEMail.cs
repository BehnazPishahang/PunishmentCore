

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Trm.EMail
{
    public abstract class TrmEMailBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DOCID")]
        public virtual string? DocId { get; set; }

        [Unicode(false)]
        [Column("DOCNO")]
        public virtual string? DocNo { get; set; }

        [Unicode(false)]
        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Unicode(false)]
        [Column("EMAILID")]
        public virtual string? EMailID { get; set; }

        [Column("EMAILSTATUS")]
        public virtual Anu.BaseInfo.Enumerations.CMSEMailStatus? EMailStatus { get; set; }

        [Unicode(false)]
        [Column("EMAILTEXT")]
        public virtual string? EMailText { get; set; }

        [Unicode(false)]
        [Column("EMAILTITLE")]
        public virtual string? EMailTitle { get; set; }

        [Unicode(false)]
        [Column("EMAILTYPE")]
        public virtual string? EMailType { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Unicode(false)]
        [Column("RESPONSEDATETIME")]
        public virtual string? ResponseDateTime { get; set; }

        [Unicode(false)]
        [Column("SENDDATETIME")]
        public virtual string? SendDateTime { get; set; }

        [ForeignKey("CREATEDORGID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCreatedOrg { get; set; }

        [ForeignKey("CREATEDSERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCreatedServer { get; set; }

        [ForeignKey("TRMEMAILID")]
        public virtual List<Anu.BaseInfo.DataModel.Trm.EMail.TrmEMailNotSend>? TheTrmEMailNotSendList { get; set; }

    }

    [Table("TRMEMAIL")]
    public partial class TrmEMail : TrmEMailBase
    {
    }
    }