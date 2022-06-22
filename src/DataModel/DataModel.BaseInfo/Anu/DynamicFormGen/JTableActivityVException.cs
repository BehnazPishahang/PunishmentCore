

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableActivityVExceptionBase : BaseInfoEntity<string>
    {

		[ForeignKey("JTABLEACTIVITYVALIDATORID")]
		public virtual Anu.DynamicFormGen.JTableActivityValidator? TheJTableActivityValidator { get; set; }

    }
    [Table("JTABLEACTIVITYVEXCEPTION")]
    public partial class JTableActivityVException : JTableActivityVExceptionBase { }

    }


