

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Attachment
{
    public abstract class GBatchInsertBase : BaseInfoEntity<string>
    {

		[Column("BATCHINSTYPE")]
		public virtual Rad.CMS.Enumerations.BatchInsType? BatchInsType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[Column("LASTINSRECPOINTER")]
		public virtual decimal? LastInsRecPointer { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("RELATEDSYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedSystemForm { get; set; }

		[ForeignKey("RELATEDSYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }
    [Table("GBATCHINSERT")]
    public partial class GBatchInsert : GBatchInsertBase { }

    }


