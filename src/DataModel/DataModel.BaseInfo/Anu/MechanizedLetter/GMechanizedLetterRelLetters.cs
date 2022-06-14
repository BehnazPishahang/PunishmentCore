

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.MechanizedLetter
{
    public abstract class GMechanizedLetterRelLettersBase : BaseInfoEntity<string>
    {

		[Column("RELATIONTYPE")]
		public virtual Anu.Enumerations.MechanizedLetterRelType? RelationType { get; set; }

		[Column("RELLETTERDATE")]
		public virtual string? RelLetterDate { get; set; }

		[Column("RELLETTERGETTYPE")]
		public virtual Anu.Enumerations.MechanizedLetterRelLetterGetType? RelLetterGetType { get; set; }

		[Column("RELLETTERNO")]
		public virtual string? RelLetterNo { get; set; }

		[ForeignKey("MAINLETTERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetter? TheMainLetter { get; set; }

		[ForeignKey("RELLETTERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetter? TheRelLetter { get; set; }

    }
    [Table("GMECHANIZEDLETTERRELLETTERS")]
    public partial class GMechanizedLetterRelLetters : GMechanizedLetterRelLettersBase { }

    }


