

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Types
{
    public abstract class OutputLetterTypeTranscriptBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[ForeignKey("OUTPUTLETTERTYPEID")]
		public virtual Anu.BaseInfo.Types.OutputLetterType? TheOutputLetterType { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

    }
    [Table("OUTPUTLETTERTYPETRANSCRIPT")]
    public partial class OutputLetterTypeTranscript : OutputLetterTypeTranscriptBase { }

    }


