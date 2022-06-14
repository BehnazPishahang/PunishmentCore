

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBEducationLevelBase : BaseInfoEntity<string>
    {

    }
    [Table("JBEDUCATIONLEVEL")]
    public partial class JBEducationLevel : JBEducationLevelBase { }

    }


