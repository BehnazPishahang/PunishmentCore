

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.DigitalSignature
{
    public abstract class DataSignatureBase : BaseInfoEntity<string>
    {

		[Column("DATETIME")]
		public virtual string? DateTime { get; set; }

		[Column("INVOKERACTIONNAME")]
		public virtual string? InvokerActionName { get; set; }

		[Column("SIGNOBJECTID")]
		public virtual string? SignObjectId { get; set; }

		[Column("SIGNVALUE")]
		public virtual string? SignValue { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("SIGNATUREDEFINITIONID")]
		public virtual Rad.BaseInfo.Pki.DigitalSignature.SignatureDefinition? TheSignatureDefinition { get; set; }

    }
    [Table("DATASIGNATURE")]
    public partial class DataSignature : DataSignatureBase { }

    }


