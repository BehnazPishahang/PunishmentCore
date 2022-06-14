

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Attachment
{
    public abstract class GChangeStateHistoryBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("CHANGESECOND")]
		public virtual decimal? ChangeSecond { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("NEXTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheNextState { get; set; }

		[ForeignKey("PREVIOUSSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? ThePreviousState { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("GCHANGESTATEHISTORY")]
    public partial class GChangeStateHistory : GChangeStateHistoryBase { }

    }


