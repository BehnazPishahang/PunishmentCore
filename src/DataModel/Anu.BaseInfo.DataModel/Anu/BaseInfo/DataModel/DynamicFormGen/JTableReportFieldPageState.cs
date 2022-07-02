

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldPageStateBase : BaseInfoEntity<string>
    {

        [Column("CONDITIONEXP")]
        public virtual string? ConditionExp { get; set; }

        [Column("INVISIBLEDISABLE")]
        public virtual Anu.BaseInfo.Enumerations.InvisibleDisable? InvisibleDisable { get; set; }

        [InverseProperty("TheField4GroupCondition")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldCondition>? TheGroupConditionList { get; set; }

        [ForeignKey("JTABLEREPORTFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

        [ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

    }

    [Table("JTABLEREPORTFIELDPAGESTATE")]
    public partial class JTableReportFieldPageState : JTableReportFieldPageStateBase
    {
    }
}