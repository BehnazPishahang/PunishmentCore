

using System.ComponentModel.DataAnnotations.Schema;

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