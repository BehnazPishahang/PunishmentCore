

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBBaseInfoBudgetConnectionsBase : BaseInfoEntity<string>
    {

        [Column("CHANGETYPE")]
        public virtual Anu.BaseInfo.Enumerations.BaseInfoChangeType? ChangeType { get; set; }

        [ForeignKey("NEWRECID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBBaseInfoBudget? TheNewRec { get; set; }

        [ForeignKey("OLDRECID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBBaseInfoBudget? TheOldRec { get; set; }

    }

    [Table("JBBASEINFOBUDGETCONNECTIONS")]
    public partial class JBBaseInfoBudgetConnections : JBBaseInfoBudgetConnectionsBase
    {
    }
}