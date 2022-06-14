

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestRelatedDataBase : BaseInfoEntity<string>
    {

		[Column("LABEL")]
		public virtual string? Label { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("VALUE")]
		public virtual string? Value { get; set; }

    }
    [Table("GREQUESTRELATEDDATA")]
    public partial class GRequestRelatedData : GRequestRelatedDataBase { }

    }


