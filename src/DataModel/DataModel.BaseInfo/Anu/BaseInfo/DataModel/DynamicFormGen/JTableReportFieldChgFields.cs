

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldChgFieldsBase : BaseInfoEntity<string>
    {

        [ForeignKey("CHANGEFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheChangeField { get; set; }

    }

    [Table("JTABLEREPORTFIELDCHGFIELDS")]
    public partial class JTableReportFieldChgFields : JTableReportFieldChgFieldsBase
    {
    }
}