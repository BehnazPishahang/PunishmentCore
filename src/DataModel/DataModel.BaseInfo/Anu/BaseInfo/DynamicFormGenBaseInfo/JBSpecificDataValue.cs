

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBSpecificDataValueBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectID { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("JBSPECIFICDATAID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBSpecificData? TheJBSpecificData { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JBSPECIFICDATAVALUE")]
    public partial class JBSpecificDataValue : JBSpecificDataValueBase { }

    }


