

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DBLoging
{
    public abstract class ChangeLogCaseBase : BaseInfoEntity<string>
    {

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseId { get; set; }

		[ForeignKey("CASESYSTEMOBJECTTYPEID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheCaseSystemObjectType { get; set; }

		[ForeignKey("CHANGELOGID")]
		public virtual Anu.DBLoging.ChangeLog? TheChangeLog { get; set; }

    }
    [Table("CHANGELOGCASE")]
    public partial class ChangeLogCase : ChangeLogCaseBase { }

    }


