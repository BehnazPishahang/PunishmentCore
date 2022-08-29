using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Attachment
{
    public abstract class GChangeStateHistoryBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("CHANGESECOND")]
        public virtual long? ChangeSecond { get; set; }

        [Unicode(false)]
        [Column("HAMESH")]
        public virtual string? Hamesh { get; set; }

        [Unicode(false)]
        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [ForeignKey("CMSUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

        [ForeignKey("INORGUSERPOSTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheInOrgUserPost { get; set; }

        [ForeignKey("NEXTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheNextState { get; set; }

        [ForeignKey("OUTORGUSERPOSTID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess? TheOutOrgUserPost { get; set; }

        [ForeignKey("PREVIOUSSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? ThePreviousState { get; set; }

        [ForeignKey("RELATEDFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedForm { get; set; }

        [ForeignKey("RELATEDSYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

        }

    [Table("GCHANGESTATEHISTORY")]
    public partial class GChangeStateHistory : GChangeStateHistoryBase
    {
    }
    }