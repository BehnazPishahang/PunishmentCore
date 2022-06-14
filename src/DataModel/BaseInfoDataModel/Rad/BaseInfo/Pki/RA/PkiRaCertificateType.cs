

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaCertificateTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PKIRACERTIFICATETYPE")]
    public partial class PkiRaCertificateType : PkiRaCertificateTypeBase { }

    }


