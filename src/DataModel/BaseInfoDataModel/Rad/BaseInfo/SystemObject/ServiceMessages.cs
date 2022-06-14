

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class ServiceMessagesBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("MESSAGE")]
		public virtual string? Message { get; set; }

		[Column("MESSAGETYPE")]
		public virtual Rad.CMS.Enumerations.ServiceMessageType? MessageType { get; set; }

    }
    [Table("SERVICEMESSAGES")]
    public partial class ServiceMessages : ServiceMessagesBase { }

    }


