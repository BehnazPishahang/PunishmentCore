

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class SpeakTemplateBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("REASONATTACH")]
		public virtual string? ReasonAttach { get; set; }

		[Column("RELIEFACCUSE")]
		public virtual string? ReliefAccuse { get; set; }

		[Column("SPEAK")]
		public virtual string? Speak { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("SPEAKTEMPLATE")]
    public partial class SpeakTemplate : SpeakTemplateBase { }

    }


