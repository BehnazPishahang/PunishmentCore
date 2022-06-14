

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class TrmIReceiveMsgTypeBase : BaseInfoEntity<string>
    {

		[Column("MSGNUMBER")]
		public virtual decimal? MsgNumber { get; set; }

		[Column("RELATEDSUBSYSTEM")]
		public virtual Rad.CMS.Enumerations.Subsystems? RelatedSubSystem { get; set; }

    }
    [Table("TRMIRECEIVEMSGTYPE")]
    public partial class TrmIReceiveMsgType : TrmIReceiveMsgTypeBase { }

    }


