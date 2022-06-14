

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class ChangeLogCaseBase : BaseInfoEntity<string>
    {

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseId { get; set; }

		[ForeignKey("CASESYSTEMOBJECTTYPEID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheCaseSystemObjectType { get; set; }

		[ForeignKey("CHANGELOGID")]
		public virtual Rad.DBLoging.ChangeLog? TheChangeLog { get; set; }

    }
    [Table("CHANGELOGCASE")]
    public partial class ChangeLogCase : ChangeLogCaseBase { }

    }


