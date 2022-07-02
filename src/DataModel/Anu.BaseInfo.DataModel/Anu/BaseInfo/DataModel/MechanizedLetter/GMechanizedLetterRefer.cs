

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.MechanizedLetter
{
    public abstract class GMechanizedLetterReferBase : BaseInfoEntity<string>
    {

        [Column("RECEIVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

        [Column("REFERNUMBER")]
        public virtual long? ReferNumber { get; set; }

        [Column("REFERORDER")]
        public virtual string? ReferOrder { get; set; }

        [Column("SENDDATETIME")]
        public virtual string? SendDateTime { get; set; }

        [Column("SENDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MLetterSendTYpe? SendType { get; set; }

        [ForeignKey("GMECHANIZEDLETTERRECEIVERID")]
        public virtual Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetterReceiver? TheGMechanizedLetterReceiver { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("RECEIVERORGID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheReceiverOrg { get; set; }

        [ForeignKey("RECEIVERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheReceiverRoleType { get; set; }

        [ForeignKey("RECEIVERUSERANDPOSTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheReceiverUserAndPost { get; set; }

        [ForeignKey("SENDERUSERANDPOSTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheSenderUserAndPost { get; set; }

        [Column("VIEWDATETIME")]
        public virtual string? ViewDateTime { get; set; }

        [Column("VIEWERUSERNAME")]
        public virtual string? ViewerUserName { get; set; }

    }

    [Table("GMECHANIZEDLETTERREFER")]
    public partial class GMechanizedLetterRefer : GMechanizedLetterReferBase
    {
    }
}