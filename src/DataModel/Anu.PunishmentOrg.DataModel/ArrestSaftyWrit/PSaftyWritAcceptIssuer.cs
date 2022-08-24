using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PSaftyWritAcceptIssuerBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PSAFTYWRITACCEPTID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritAccept? ThePSaftyWritAccept { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        }

    [Table("PSAFTYWRITACCEPTISSUER")]
    public partial class PSaftyWritAcceptIssuer : PSaftyWritAcceptIssuerBase
    {
    }
    }