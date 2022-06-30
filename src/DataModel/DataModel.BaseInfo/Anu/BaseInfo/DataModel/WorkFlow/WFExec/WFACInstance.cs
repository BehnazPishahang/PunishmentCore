

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.WorkFlow.WFExec
{
    public abstract class WFACInstanceBase : BaseInfoEntity<string>
    {

        [Column("COMPLETEDINPUTCOUNT")]
        public virtual long? CompletedInputCount { get; set; }

        [Column("IDPARAMVAL")]
        public virtual string? IDParamVal { get; set; }

        [Column("ROWNO")]
        public virtual long? RowNo { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState? State { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [InverseProperty("TheWFACInstance")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFACInstanceParam>? TheWFACInstanceParamList { get; set; }

        [InverseProperty("TheWFACInstance")]
        public virtual List<Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFACInstanceTrans>? TheWFACInstanceTransList { get; set; }

        [ForeignKey("WFACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

        [ForeignKey("WFINSTANCEID")]
        public virtual Anu.BaseInfo.DataModel.WorkFlow.WFExec.WFInstance? TheWFInstance { get; set; }

    }

    [Table("WFACINSTANCE")]
    public partial class WFACInstance : WFACInstanceBase
    {
    }
}