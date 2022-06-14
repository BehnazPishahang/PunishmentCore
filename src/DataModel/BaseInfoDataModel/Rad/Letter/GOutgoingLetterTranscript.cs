

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
{
    public abstract class GOutgoingLetterTranscriptBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("SENDTYPE")]
		public virtual Rad.CMS.Enumerations.TranscriptSendType? SendType { get; set; }

		[ForeignKey("GOUTGOINGLETTERID")]
		public virtual Rad.Letter.GOutgoingLetter? TheGOutgoingLetter { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

    }
    [Table("GOUTGOINGLETTERTRANSCRIPT")]
    public partial class GOutgoingLetterTranscript : GOutgoingLetterTranscriptBase { }

    }


