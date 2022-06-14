

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBCaseStoreUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBCASESTOREID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBCaseStore? ThePBCaseStore { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBCASESTOREUNIT")]
    public partial class PBCaseStoreUnit : PBCaseStoreUnitBase { }

    }


