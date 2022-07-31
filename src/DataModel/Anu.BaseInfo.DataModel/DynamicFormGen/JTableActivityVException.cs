

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableActivityVExceptionBase : BaseInfoEntity<string>
    {

        [ForeignKey("JTABLEACTIVITYVALIDATORID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableActivityValidator? TheJTableActivityValidator { get; set; }

    }

    [Table("JTABLEACTIVITYVEXCEPTION")]
    public partial class JTableActivityVException : JTableActivityVExceptionBase
    {
    }
    }