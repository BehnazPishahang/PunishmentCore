

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgViewAttributesBase : BaseInfoEntity<string>
    {

		[Column("ATTRIBUTELENGTH")]
		public virtual decimal? AttributeLength { get; set; }

		[Column("ATTRIBUTETYPE")]
		public virtual Rad.CMS.Enumerations.RpgAttributeType? AttributeType { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("ISVISABLE4USER")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? IsVisable4User { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("RPGENUMERATIONSID")]
		public virtual Rad.ReportGenerator.RpgEnumerations? TheRpgEnumerations { get; set; }

		[ForeignKey("RPGVIEWSID")]
		public virtual Rad.ReportGenerator.RpgViews? TheRpgViews { get; set; }

    }
    [Table("RPGVIEWATTRIBUTES")]
    public partial class RpgViewAttributes : RpgViewAttributesBase { }

    }


