

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.DigitalSignature
{
    public abstract class SignatureDefinitionBase : BaseInfoEntity<string>
    {

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("SIGNDEFINITIONVERSION")]
		public virtual string? SignDefinitionVersion { get; set; }

		[Column("SIGNDESCRIPTOR")]
		public virtual string? SignDescriptor { get; set; }

		[Column("SIGNMETHOD")]
		public virtual string? SignMethod { get; set; }

		[InverseProperty("TheSignatureDefinition")]
		public virtual List<Rad.BaseInfo.Pki.DigitalSignature.DataSignature>? TheDataSignatureList { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

    }
    [Table("SIGNATUREDEFINITION")]
    public partial class SignatureDefinition : SignatureDefinitionBase { }

    }


