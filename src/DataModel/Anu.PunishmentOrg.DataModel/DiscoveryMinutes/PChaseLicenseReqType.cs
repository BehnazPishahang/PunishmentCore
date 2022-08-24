using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CHASELICENSETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUChaseLicenseType? ChaseLicenseType { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        }

    [Table("PCHASELICENSEREQTYPE")]
    public partial class PChaseLicenseReqType : PChaseLicenseReqTypeBase
    {
    }
    }