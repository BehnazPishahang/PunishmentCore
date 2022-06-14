

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class ChangeLogFieldsBase : BaseInfoEntity<string>
    {

		[Column("BLOBFIELDTYPE")]
		public virtual Rad.CMS.Enumerations.LOBFieldType? BLOBFieldType { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NOWBLOBDATA")]
		public virtual byte[]? NowBLOBData { get; set; }

		[Column("NOWCLOBDATA")]
		public virtual string? NowCLOBData { get; set; }

		[Column("NOWDATA")]
		public virtual string? NowData { get; set; }

		[Column("PREVIOUSBLOBDATA")]
		public virtual byte[]? PreviousBLOBData { get; set; }

		[Column("PREVIOUSCLOBDATA")]
		public virtual string? PreviousCLOBData { get; set; }

		[Column("PREVIOUSDATA")]
		public virtual string? PreviousData { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[Column("SYSTEMFORMID")]
		public virtual string? SystemFormId { get; set; }

		[ForeignKey("CHANGELOGMAINDOCID")]
		public virtual Rad.DBLoging.ChangeLogMainDoc? TheChangeLogMainDoc { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("CHANGELOGFIELDS")]
    public partial class ChangeLogFields : ChangeLogFieldsBase { }

    }


