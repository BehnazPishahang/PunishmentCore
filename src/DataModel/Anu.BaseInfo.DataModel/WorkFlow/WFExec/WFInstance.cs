

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFExec
{
    public abstract class WFInstanceBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("IDPARAMVAL")]
        public virtual string? IDParamVal { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [InverseProperty("TheWFInstance")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFACInstance>? TheWFACInstanceList { get; set; }

        [InverseProperty("TheWFInstance")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFInstanceParamVal>? TheWFInstanceParamValList { get; set; }

        [ForeignKey("WFWORKFLOWID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFWorkflow? TheWFWorkflow { get; set; }

    }

    [Table("WFINSTANCE")]
    public partial class WFInstance : WFInstanceBase
    {
    }
    }