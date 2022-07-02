

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Trm.EMail
{
    public abstract class TrmEMailBase : BaseInfoEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DOCID")]
        public virtual string? DocId { get; set; }

        [Column("DOCNO")]
        public virtual string? DocNo { get; set; }

        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Column("EMAILID")]
        public virtual string? EMailID { get; set; }

        [Column("EMAILSTATUS")]
        public virtual Anu.BaseInfo.Enumerations.CMSEMailStatus? EMailStatus { get; set; }

        [Column("EMAILTEXT")]
        public virtual string? EMailText { get; set; }

        [Column("EMAILTITLE")]
        public virtual string? EMailTitle { get; set; }

        [Column("EMAILTYPE")]
        public virtual string? EMailType { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Column("RESPONSEDATETIME")]
        public virtual string? ResponseDateTime { get; set; }

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