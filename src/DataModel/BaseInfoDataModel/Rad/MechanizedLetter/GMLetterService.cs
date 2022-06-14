

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMLetterServiceBase : BaseInfoEntity<string>
    {

		[Column("ALLOWMULTISELECT")]
		public virtual Rad.CMS.Enumerations.YesNo? AllowMultiSelect { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("FULLNAME")]
		public virtual string? FullName { get; set; }

		[Column("SQLCOMMAND")]
		public virtual string? SqlCommand { get; set; }

		[InverseProperty("TheGMLetterService")]
		public virtual List<Rad.MechanizedLetter.GMLetterServiceField>? TheGMLetterServiceFieldList { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GMLETTERSERVICE")]
    public partial class GMLetterService : GMLetterServiceBase { }

    }


