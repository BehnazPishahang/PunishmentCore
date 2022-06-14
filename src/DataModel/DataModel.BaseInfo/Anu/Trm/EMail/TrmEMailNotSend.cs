

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Trm.EMail
{
    public abstract class TrmEMailNotSendBase : BaseInfoEntity<string>
    {

		[Column("DISPATCHDATETIME")]
		public virtual string? DispatchDateTime { get; set; }

    }
    [Table("TRMEMAILNOTSEND")]
    public partial class TrmEMailNotSend : TrmEMailNotSendBase { }

    }


