

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Advertising
{
    public abstract class GAdvertisingRelatedDocBase : BaseInfoEntity<string>
    {

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocID { get; set; }

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[ForeignKey("GADVERTISINGID")]
		public virtual Anu.Advertising.GAdvertising? TheGAdvertising { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GADVERTISINGRELATEDDOC")]
    public partial class GAdvertisingRelatedDoc : GAdvertisingRelatedDocBase { }

    }


