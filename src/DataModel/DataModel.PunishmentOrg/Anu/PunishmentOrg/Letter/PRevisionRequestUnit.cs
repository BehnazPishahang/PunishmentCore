

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class PRevisionRequestUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PREVISIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

    }
    [Table("PREVISIONREQUESTUNIT")]
    public partial class PRevisionRequestUnit : PRevisionRequestUnitBase { }

    }


