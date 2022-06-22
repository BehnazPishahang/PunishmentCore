

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqCrimBase : PunishmentOrgEntity<string>
    {

		[Column("CRIMES")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.Crimes? Crimes { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

    }
    [Table("PCHASELICENSEREQCRIM")]
    public partial class PChaseLicenseReqCrim : PChaseLicenseReqCrimBase { }

    }


