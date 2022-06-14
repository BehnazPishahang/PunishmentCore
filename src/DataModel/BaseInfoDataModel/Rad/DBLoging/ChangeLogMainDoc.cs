

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class ChangeLogMainDocBase : BaseInfoEntity<string>
    {

		[Column("ISBASEFORMOBJECT")]
		public virtual Rad.CMS.Enumerations.YesNo? IsBaseFormObject { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("CHANGEDATATYPEID")]
		public virtual Rad.BaseInfo.Types.ChangeDataType? TheChangeDataType { get; set; }

		[ForeignKey("CHANGELOGID")]
		public virtual Rad.DBLoging.ChangeLog? TheChangeLog { get; set; }

		[InverseProperty("TheChangeLogMainDoc")]
		public virtual List<Rad.DBLoging.ChangeLogFields>? TheChangeLogFieldsList { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("CHANGELOGMAINDOC")]
    public partial class ChangeLogMainDoc : ChangeLogMainDocBase { }

    }


