

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportGrpRelationBase : BaseInfoEntity<string>
    {

        [ForeignKey("DETAILGRPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? TheDetailGrp { get; set; }

        [ForeignKey("DETAILRELATIONCOLID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheDetailRelationCol { get; set; }

        [ForeignKey("MASTERGRPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? TheMasterGrp { get; set; }

        [ForeignKey("MASTERRELATIONCOLID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheMasterRelationCol { get; set; }

        [ForeignKey("MASTERRELATIONFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheMasterRelationField { get; set; }

    }

    [Table("JTABLEREPORTGRPRELATION")]
    public partial class JTableReportGrpRelation : JTableReportGrpRelationBase
    {
    }
}