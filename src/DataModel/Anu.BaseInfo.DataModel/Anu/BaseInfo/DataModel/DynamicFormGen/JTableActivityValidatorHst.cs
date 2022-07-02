

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableActivityValidatorHstBase : BaseInfoEntity<string>
    {

        [Column("FROMCHANGEDATETIME")]
        public virtual string? FromChangeDateTime { get; set; }

        [Column("FROMMILISECOND")]
        public virtual string? FromMiliSecond { get; set; }

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [ForeignKey("JTABLEREPORTACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportActivity? TheJTableReportActivity { get; set; }

        [Column("TOCHANGEDATETIME")]
        public virtual string? ToChangeDateTime { get; set; }

        [Column("TOMILISECOND")]
        public virtual string? ToMiliSecond { get; set; }

    }

    [Table("JTABLEACTIVITYVALIDATORHST")]
    public partial class JTableActivityValidatorHst : JTableActivityValidatorHstBase
    {
    }
}