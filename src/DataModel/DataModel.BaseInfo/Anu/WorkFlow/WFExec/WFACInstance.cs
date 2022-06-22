

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.WorkFlow.WFExec
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
		public virtual Anu.Enumerations.WorkFlowActivityInstanceState? State { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[InverseProperty("TheWFACInstance")]
		public virtual List<Anu.WorkFlow.WFExec.WFACInstanceParam>? TheWFACInstanceParamList { get; set; }

		[InverseProperty("TheWFACInstance")]
		public virtual List<Anu.WorkFlow.WFExec.WFACInstanceTrans>? TheWFACInstanceTransList { get; set; }

		[ForeignKey("WFACTIVITYID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivity? TheWFActivity { get; set; }

		[ForeignKey("WFINSTANCEID")]
		public virtual Anu.WorkFlow.WFExec.WFInstance? TheWFInstance { get; set; }

    }
    [Table("WFACINSTANCE")]
    public partial class WFACInstance : WFACInstanceBase { }

    }


