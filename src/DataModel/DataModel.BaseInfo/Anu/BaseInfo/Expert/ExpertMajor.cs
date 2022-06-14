

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Expert
{
    public abstract class ExpertMajorBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("EXPERTGROUPID")]
		public virtual Anu.BaseInfo.Expert.ExpertGroup? TheExpertGroup { get; set; }

		[InverseProperty("TheExpertMajor")]
		public virtual List<Anu.BaseInfo.Expert.ExpertManSubject>? TheExpertManSubjectList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("EXPERTMAJOR")]
    public partial class ExpertMajor : ExpertMajorBase { }

    }


