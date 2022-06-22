

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Types
{
    public abstract class GObjectDefaultTextBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DEFAULTTEXT")]
		public virtual string? DefaultText { get; set; }

		[Column("RELATEDRECID")]
		public virtual string? RelatedRecId { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("RELATEDOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GOBJECTDEFAULTTEXT")]
    public partial class GObjectDefaultText : GObjectDefaultTextBase { }

    }


