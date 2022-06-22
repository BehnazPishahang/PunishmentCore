

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class PArticle23ActionRequestUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PARTICLE23ACTIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PArticle23ActionRequest? ThePArticle23ActionRequest { get; set; }

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

    }
    [Table("PARTICLE23ACTIONREQUESTUNIT")]
    public partial class PArticle23ActionRequestUnit : PArticle23ActionRequestUnitBase { }

    }


