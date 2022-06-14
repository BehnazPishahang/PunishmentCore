

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaReqAnnexImageBase : BaseInfoEntity<string>
    {

		[Column("DOCIMAGE")]
		public virtual byte[]? DocImage { get; set; }

		[Column("PKIRAREQANNEXID")]
		public virtual string? PkiRaReqAnnexId { get; set; }

    }
    [Table("PKIRAREQANNEXIMAGE")]
    public partial class PkiRaReqAnnexImage : PkiRaReqAnnexImageBase { }

    }


