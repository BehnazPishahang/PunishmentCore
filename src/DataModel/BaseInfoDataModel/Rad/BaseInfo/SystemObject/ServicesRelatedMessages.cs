

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class ServicesRelatedMessagesBase : BaseInfoEntity<string>
    {

		[ForeignKey("SERVICEMESSAGESID")]
		public virtual Rad.BaseInfo.SystemObject.ServiceMessages? TheServiceMessages { get; set; }

		[ForeignKey("SYSTEMSERVICESID")]
		public virtual Rad.BaseInfo.SystemObject.SystemServices? TheSystemServices { get; set; }

    }
    [Table("SERVICESRELATEDMESSAGES")]
    public partial class ServicesRelatedMessages : ServicesRelatedMessagesBase { }

    }


