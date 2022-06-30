

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemMessageBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("MSGTEXT")]
        public virtual string? MsgText { get; set; }

        [Column("PARAMETERCOUNT")]
        public virtual long? ParameterCount { get; set; }

    }

    [Table("SYSTEMMESSAGE")]
    public partial class SystemMessage : SystemMessageBase
    {
    }
}