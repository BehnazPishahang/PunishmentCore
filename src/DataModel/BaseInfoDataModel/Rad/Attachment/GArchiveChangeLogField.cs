

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Attachment
{
    public abstract class GArchiveChangeLogFieldBase : BaseInfoEntity<string>
    {

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NOWDATA")]
		public virtual string? NowData { get; set; }

		[Column("PREVIOUSDATA")]
		public virtual string? PreviousData { get; set; }

		[ForeignKey("GARCHIVECHANGELOGID")]
		public virtual Rad.Attachment.GArchiveChangeLog? TheGArchiveChangeLog { get; set; }

    }
    [Table("GARCHIVECHANGELOGFIELD")]
    public partial class GArchiveChangeLogField : GArchiveChangeLogFieldBase { }

    }


