

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
{
    public abstract class GIncomingLetterFieldsBase : BaseInfoEntity<string>
    {

		[Column("AMOUNT")]
		public virtual decimal? Amount { get; set; }

		[Column("DOCFILE")]
		public virtual byte[]? DocFile { get; set; }

		[Column("FIELDDESC")]
		public virtual string? FieldDesc { get; set; }

		[Column("SELECTEDLOOKUPID")]
		public virtual string? SelectedLookupId { get; set; }

		[ForeignKey("GINCOMINGLETTERID")]
		public virtual Rad.Letter.GIncomingLetter? TheGIncomingLetter { get; set; }

		[ForeignKey("INPUTLETTERTYPEFIELDID")]
		public virtual Rad.BaseInfo.Types.InputLetterTypeField? TheInputLetterTypeField { get; set; }

		[Column("TURN")]
		public virtual decimal? Turn { get; set; }

    }
    [Table("GINCOMINGLETTERFIELDS")]
    public partial class GIncomingLetterFields : GIncomingLetterFieldsBase { }

    }


