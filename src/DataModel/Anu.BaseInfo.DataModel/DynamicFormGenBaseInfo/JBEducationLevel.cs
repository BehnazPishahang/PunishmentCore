using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo;


namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBEducationLevelBase : JBBaseInfoBudget
    {

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("JBEDUCATIONLEVEL")]
    public partial class JBEducationLevel : JBEducationLevelBase
    {
    }
    }