

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBExchangeUnitBase : PunishmentOrgEntity<string>
    {

		[Column("DISCOVERYUNITTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DiscoveryUnitType? DiscoveryUnitType { get; set; }

		[Column("ISPRODUCTKEEPER")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? IsProductKeeper { get; set; }

    }
    [Table("PBEXCHANGEUNIT")]
    public partial class PBExchangeUnit : PBExchangeUnitBase { }

    }


