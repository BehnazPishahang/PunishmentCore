

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CHASELICENSETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUChaseLicenseType? ChaseLicenseType { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

    }
    [Table("PCHASELICENSEREQTYPE")]
    public partial class PChaseLicenseReqType : PChaseLicenseReqTypeBase { }

    }


