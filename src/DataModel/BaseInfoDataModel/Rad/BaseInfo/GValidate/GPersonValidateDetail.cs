

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GValidate
{
    public abstract class GPersonValidateDetailBase : BaseInfoEntity<string>
    {

		[Column("ENDDATEVALIDITY")]
		public virtual string? EndDateValidity { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("PERSONTYPE")]
		public virtual Rad.CMS.Enumerations.PersonType? PersonType { get; set; }

		[Column("RELATEDENTITYID")]
		public virtual string? RelatedEntityID { get; set; }

		[Column("SEX")]
		public virtual Rad.CMS.Enumerations.SexType? Sex { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GVALIDATIONTYPEID")]
		public virtual Rad.BaseInfo.Types.GValidationType? TheGValidationType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GPERSONVALIDATEDETAIL")]
    public partial class GPersonValidateDetail : GPersonValidateDetailBase { }

    }


