

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PSaftyWritIssuerBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PSAFTYWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWrit? ThePSaftyWrit { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("PSAFTYWRITISSUER")]
    public partial class PSaftyWritIssuer : PSaftyWritIssuerBase
    {
    }
    }