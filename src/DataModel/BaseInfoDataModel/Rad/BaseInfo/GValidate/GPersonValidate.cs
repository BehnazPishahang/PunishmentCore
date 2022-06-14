

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GValidate
{
    public abstract class GPersonValidateBase : BaseInfoEntity<string>
    {

		[Column("ACCESSNO")]
		public virtual string? AccessNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocID { get; set; }

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[ForeignKey("GPERSONVALIDATEID")]
		public virtual List<Rad.BaseInfo.GValidate.GPersonValidateDetail>? TheGPersonValidateDetailList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GPERSONVALIDATE")]
    public partial class GPersonValidate : GPersonValidateBase { }

    }


