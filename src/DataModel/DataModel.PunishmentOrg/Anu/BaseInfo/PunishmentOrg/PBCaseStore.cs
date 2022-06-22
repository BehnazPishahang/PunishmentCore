

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBCaseStoreBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[Column("STORENAME")]
		public virtual string? StoreName { get; set; }

		[InverseProperty("ThePBCaseStore")]
		public virtual List<Anu.BaseInfo.PunishmentOrg.PBCaseStoreUnit>? ThePBCaseStoreUnitList { get; set; }

    }
    [Table("PBCASESTORE")]
    public partial class PBCaseStore : PBCaseStoreBase { }

    }


