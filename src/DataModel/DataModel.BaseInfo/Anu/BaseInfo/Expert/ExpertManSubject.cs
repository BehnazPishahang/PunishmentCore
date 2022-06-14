

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Expert
{
    public abstract class ExpertManSubjectBase : BaseInfoEntity<string>
    {

		[ForeignKey("EXPERTMAJORID")]
		public virtual Anu.BaseInfo.Expert.ExpertMajor? TheExpertMajor { get; set; }

		[ForeignKey("EXPERTMANID")]
		public virtual Anu.BaseInfo.Expert.ExpertMan? TheExpertMan { get; set; }

    }
    [Table("EXPERTMANSUBJECT")]
    public partial class ExpertManSubject : ExpertManSubjectBase { }

    }


