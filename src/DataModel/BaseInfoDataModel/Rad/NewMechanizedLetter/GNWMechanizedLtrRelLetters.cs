

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.NewMechanizedLetter
{
    public abstract class GNWMechanizedLtrRelLettersBase : BaseInfoEntity<string>
    {

		[Column("RELATIONTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizedLetterRelType? RelationType { get; set; }

		[Column("RELLETTERDATE")]
		public virtual string? RelLetterDate { get; set; }

		[Column("RELLETTERGETTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizedLetterRelLetterGetType? RelLetterGetType { get; set; }

		[Column("RELLETTERNO")]
		public virtual string? RelLetterNo { get; set; }

		[ForeignKey("MAINLETTERID")]
		public virtual Rad.NewMechanizedLetter.GNWMechanizedLetter? TheMainLetter { get; set; }

		[ForeignKey("RELLETTERID")]
		public virtual Rad.NewMechanizedLetter.GNWMechanizedLetter? TheRelLetter { get; set; }

    }
    [Table("GNWMECHANIZEDLTRRELLETTERS")]
    public partial class GNWMechanizedLtrRelLetters : GNWMechanizedLtrRelLettersBase { }

    }


