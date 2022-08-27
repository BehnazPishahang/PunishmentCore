using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.WorkFlow.WFExec
{
    public abstract class WFInstanceParamValBase : BaseInfoEntity<string>
    {

        [Column("BLOBPARAMVAL")]
        public virtual byte[]? BLOBParamVal { get; set; }

        [Unicode(false)]
        [Column("CLOBPARAMVAL")]
        public virtual string? CLOBParamVal { get; set; }

        [Unicode(false)]
        [Column("IDPARAMVAL")]
        public virtual string? IDParamVal { get; set; }

        [Column("NUMBERPARAMVAL")]
        public virtual long? NumberParamVal { get; set; }

        [Unicode(false)]
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