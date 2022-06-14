

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMLetterServiceFieldBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("FIELDCLASSNAME")]
		public virtual string? FieldClassName { get; set; }

		[Column("FIELDFULLNAME")]
		public virtual string? FieldFullName { get; set; }

		[Column("FIELDVALUE")]
		public virtual string? FieldValue { get; set; }

		[Column("ISMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMandatory { get; set; }

		[ForeignKey("GMLETTERSERVICEID")]
		public virtual Rad.MechanizedLetter.GMLetterService? TheGMLetterService { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GMLETTERSERVICEFIELD")]
    public partial class GMLetterServiceField : GMLetterServiceFieldBase { }

    }


