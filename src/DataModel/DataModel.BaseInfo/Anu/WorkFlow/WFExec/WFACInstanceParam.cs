

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.WorkFlow.WFExec
{
    public abstract class WFACInstanceParamBase : BaseInfoEntity<string>
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

		[ForeignKey("WFACINSTANCEID")]
		public virtual Anu.WorkFlow.WFExec.WFACInstance? TheWFACInstance { get; set; }

		[ForeignKey("WFACTIVITYPARAMETERID")]
		public virtual Anu.WorkFlow.WFDefine.WFActivityParameter? TheWFActivityParameter { get; set; }

    }
    [Table("WFACINSTANCEPARAM")]
    public partial class WFACInstanceParam : WFACInstanceParamBase { }

    }


