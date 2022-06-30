

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class TemplateUsageTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("TEMPLATEUSAGETYPE")]
    public partial class TemplateUsageType : TemplateUsageTypeBase
    {
    }
}