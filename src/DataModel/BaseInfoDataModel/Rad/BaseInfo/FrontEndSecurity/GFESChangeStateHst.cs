

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.FrontEndSecurity
{
    public abstract class GFESChangeStateHstBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("CHANGESECOND")]
		public virtual decimal? ChangeSecond { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("GFESUSERACCESSID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

		[ForeignKey("NEXTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheNextState { get; set; }

		[ForeignKey("PREVIOUSSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? ThePreviousState { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("GFESCHANGESTATEHST")]
    public partial class GFESChangeStateHst : GFESChangeStateHstBase { }

    }


