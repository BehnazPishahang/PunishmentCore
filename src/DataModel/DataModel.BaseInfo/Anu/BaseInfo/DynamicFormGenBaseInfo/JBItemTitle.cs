

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBItemTitleBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ITEMTYPE")]
		public virtual Anu.Enumerations.TypeValue? ItemType { get; set; }

		[Column("LOOKUPCOLUMNS")]
		public virtual string? LookupColumns { get; set; }

		[Column("LOOKUPWHERECOND")]
		public virtual string? LookupWhereCond { get; set; }

		[Column("MAXLENGTH")]
		public virtual decimal? MaxLength { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("JBSPECIFICDATAID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBSpecificData? TheJBSpecificData { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JBITEMTITLE")]
    public partial class JBItemTitle : JBItemTitleBase { }

    }


