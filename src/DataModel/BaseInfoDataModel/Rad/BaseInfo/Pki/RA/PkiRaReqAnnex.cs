

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaReqAnnexBase : BaseInfoEntity<string>
    {

		[Column("DOCTYPE")]
		public virtual Rad.CMS.Enumerations.PkiRaRequiredDocs? DocType { get; set; }

		[Column("ROWNO")]
		public virtual decimal? RowNo { get; set; }

		[ForeignKey("PKIRAREQID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaReq? ThePkiRaReq { get; set; }

    }
    [Table("PKIRAREQANNEX")]
    public partial class PkiRaReqAnnex : PkiRaReqAnnexBase { }

    }


