

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.GAdvertising
{
    public abstract class GAdvertisingRelatedDocBase : BaseInfoEntity<string>
    {

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocID { get; set; }

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[ForeignKey("GADVERTISINGID")]
		public virtual Rad.GAdvertising.GAdvertising? TheGAdvertising { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GADVERTISINGRELATEDDOC")]
    public partial class GAdvertisingRelatedDoc : GAdvertisingRelatedDocBase { }

    }


