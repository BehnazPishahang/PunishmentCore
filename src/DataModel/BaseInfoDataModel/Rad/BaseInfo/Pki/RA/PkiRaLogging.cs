

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Pki.RA
{
    public abstract class PkiRaLoggingBase : BaseInfoEntity<string>
    {

		[Column("ACTIONEXCEPTION")]
		public virtual string? ActionException { get; set; }

		[Column("ACTIONNAME")]
		public virtual string? ActionName { get; set; }

		[Column("ACTIONRESULT")]
		public virtual string? ActionResult { get; set; }

		[Column("ASSEMBLYNAME")]
		public virtual string? AssemblyName { get; set; }

		[Column("ISSERVERSIDE")]
		public virtual Rad.CMS.Enumerations.YesNo? IsServerSide { get; set; }

		[Column("LOCALDATETIME")]
		public virtual string? LocalDateTime { get; set; }

		[Column("SERVERDATETIME")]
		public virtual string? ServerDateTime { get; set; }

		[ForeignKey("PKIRAPROCESSLOGGINGID")]
		public virtual Rad.BaseInfo.Pki.RA.PkiRaProcessLogging? ThePkiRaProcessLogging { get; set; }

    }
    [Table("PKIRALOGGING")]
    public partial class PkiRaLogging : PkiRaLoggingBase { }

    }


