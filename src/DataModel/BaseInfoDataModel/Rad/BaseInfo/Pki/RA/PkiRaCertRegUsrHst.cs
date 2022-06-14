

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaCertRegUsrHstBase : BaseInfoEntity<string>
    {

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[ForeignKey("PKIRACERTIFICATESID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaCertificates? ThePkiRaCertificates { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PKIRACERTREGUSRHST")]
    public partial class PkiRaCertRegUsrHst : PkiRaCertRegUsrHstBase { }

    }


