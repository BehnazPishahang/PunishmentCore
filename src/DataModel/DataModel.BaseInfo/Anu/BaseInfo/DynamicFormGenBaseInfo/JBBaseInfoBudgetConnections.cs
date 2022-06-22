

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBBaseInfoBudgetConnectionsBase : BaseInfoEntity<string>
    {

		[Column("CHANGETYPE")]
		public virtual Anu.Enumerations.BaseInfoChangeType? ChangeType { get; set; }

		[ForeignKey("NEWRECID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBBaseInfoBudget? TheNewRec { get; set; }

		[ForeignKey("OLDRECID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBBaseInfoBudget? TheOldRec { get; set; }

    }
    [Table("JBBASEINFOBUDGETCONNECTIONS")]
    public partial class JBBaseInfoBudgetConnections : JBBaseInfoBudgetConnectionsBase { }

    }


