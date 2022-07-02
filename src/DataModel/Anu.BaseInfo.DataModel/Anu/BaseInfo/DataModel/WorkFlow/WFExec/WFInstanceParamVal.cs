

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFExec
{
    public abstract class WFInstanceParamValBase : BaseInfoEntity<string>
    {

        [Column("BLOBPARAMVAL")]
        public virtual byte[]? BLOBParamVal { get; set; }

        [Column("CLOBPARAMVAL")]
        public virtual string? CLOBParamVal { get; set; }

        [Column("IDPARAMVAL")]
        public virtual string? IDParamVal { get; set; }

        [Column("NUMBERPARAMVAL")]
        public virtual long? NumberParamVal { get; set; }

        [Column("STRINGPARAMVAL")]
        public virtual string? StringParamVal { get; set; }

        [ForeignKey("WFINSTANCEID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFInstance? TheWFInstance { get; set; }

        [ForeignKey("WFWORKFLOWPARAMETERID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflowParameter? TheWFWorkflowParameter { get; set; }

    }

    [Table("WFINSTANCEPARAMVAL")]
    public partial class WFInstanceParamVal : WFInstanceParamValBase
    {
    }
}