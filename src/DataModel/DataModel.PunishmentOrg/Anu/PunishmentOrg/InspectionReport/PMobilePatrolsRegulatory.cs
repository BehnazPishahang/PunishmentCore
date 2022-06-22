

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.InspectionReport
{
    public abstract class PMobilePatrolsRegulatoryBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBEXCHANGEUNITID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBExchangeUnit? ThePBExchangeUnit { get; set; }

		[ForeignKey("PMOBILEPATROLSID")]
		public virtual Anu.PunishmentOrg.InspectionReport.PMobilePatrols? ThePMobilePatrols { get; set; }

    }
    [Table("PMOBILEPATROLSREGULATORY")]
    public partial class PMobilePatrolsRegulatory : PMobilePatrolsRegulatoryBase { }

    }


