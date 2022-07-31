

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqCrimBase : PunishmentOrgEntity<string>
    {

        [Column("CRIMES")]
        public virtual Anu.BaseInfo.Enumerations.Crimes? Crimes { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

    }

    [Table("PCHASELICENSEREQCRIM")]
    public partial class PChaseLicenseReqCrim : PChaseLicenseReqCrimBase
    {
    }
    }