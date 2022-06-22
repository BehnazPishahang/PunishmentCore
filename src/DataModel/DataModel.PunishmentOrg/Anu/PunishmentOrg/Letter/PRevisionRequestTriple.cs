

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class PRevisionRequestTripleBase : PunishmentOrgEntity<string>
    {

		[Column("ISCONFIRM")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? IsConfirm { get; set; }

		[ForeignKey("PCASETRIPLEID")]
		public virtual Anu.PunishmentOrg.Case.PCaseTriple? ThePCaseTriple { get; set; }

		[ForeignKey("PREVISIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

    }
    [Table("PREVISIONREQUESTTRIPLE")]
    public partial class PRevisionRequestTriple : PRevisionRequestTripleBase { }

    }


