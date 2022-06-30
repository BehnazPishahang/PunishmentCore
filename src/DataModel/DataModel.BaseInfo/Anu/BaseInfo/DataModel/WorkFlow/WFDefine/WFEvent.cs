

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFDefine
{
    public abstract class WFEventBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ENGLISHNAME")]
        public virtual string? EnglishName { get; set; }

        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

    }

    [Table("WFEVENT")]
    public partial class WFEvent : WFEventBase
    {
    }
}