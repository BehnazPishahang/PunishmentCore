

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemMessageBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
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