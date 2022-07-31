

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableActivityValidatorHstBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FROMCHANGEDATETIME")]
        public virtual string? FromChangeDateTime { get; set; }

        [Unicode(false)]
        [Column("FROMMILISECOND")]
        public virtual string? FromMiliSecond { get; set; }

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [ForeignKey("JTABLEREPORTACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportActivity? TheJTableReportActivity { get; set; }

        [Unicode(false)]
        [Column("TOCHANGEDATETIME")]
        public virtual string? ToChangeDateTime { get; set; }

        [Unicode(false)]
        [Column("TOMILISECOND")]
        public virtual string? ToMiliSecond { get; set; }

    }

    [Table("JTABLEACTIVITYVALIDATORHST")]
    public partial class JTableActivityValidatorHst : JTableActivityValidatorHstBase
    {
    }
    }