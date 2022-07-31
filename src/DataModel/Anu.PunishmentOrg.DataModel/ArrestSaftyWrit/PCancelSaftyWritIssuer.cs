

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PCancelSaftyWritIssuerBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCANCELSAFTYWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PCancelSaftyWrit? ThePCancelSaftyWrit { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("PCANCELSAFTYWRITISSUER")]
    public partial class PCancelSaftyWritIssuer : PCancelSaftyWritIssuerBase
    {
    }
    }