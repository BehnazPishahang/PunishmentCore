using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBReportRelatedsBase : BaseInfoEntity<string>
    {

        [Column("RELATEDFORMAFFECT")]
        public virtual Anu.BaseInfo.Enumerations.RelatedFormAffect? RelatedFormAffect { get; set; }

        [ForeignKey("MAINREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBReportTitle? TheMainReport { get; set; }

        [ForeignKey("RELATEDREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBReportTitle? TheRelatedReport { get; set; }

        }

    [Table("JBREPORTRELATEDS")]
    public partial class JBReportRelateds : JBReportRelatedsBase
    {
    }
    }