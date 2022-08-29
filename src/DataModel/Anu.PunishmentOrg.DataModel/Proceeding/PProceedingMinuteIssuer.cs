using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PProceedingMinuteIssuerBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PPROCEEDINGMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinute? ThePProceedingMinute { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        }

    [Table("PPROCEEDINGMINUTEISSUER")]
    public partial class PProceedingMinuteIssuer : PProceedingMinuteIssuerBase
    {
    }
    }