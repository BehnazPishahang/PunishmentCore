

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBEducationLevelBase : BaseInfoEntity<string>
    {

    }

    [Table("JBEDUCATIONLEVEL")]
    public partial class JBEducationLevel : JBEducationLevelBase
    {
    }
    }