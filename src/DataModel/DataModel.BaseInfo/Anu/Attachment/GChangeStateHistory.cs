

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Attachment
{
    public abstract class GChangeStateHistoryBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("CHANGESECOND")]
		public virtual long? ChangeSecond { get; set; }

		[Column("HAMESH")]
		public virtual string? Hamesh { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("INORGUSERPOSTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheInOrgUserPost { get; set; }

		[ForeignKey("NEXTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheNextState { get; set; }

		[ForeignKey("OUTORGUSERPOSTID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccess? TheOutOrgUserPost { get; set; }

		[ForeignKey("PREVIOUSSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? ThePreviousState { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("GCHANGESTATEHISTORY")]
    public partial class GChangeStateHistory : GChangeStateHistoryBase { }

    }


