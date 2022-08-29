using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PEnumerationWritIssuerBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PENUMERATIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWrit? ThePEnumerationWrit { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        }

    [Table("PENUMERATIONWRITISSUER")]
    public partial class PEnumerationWritIssuer : PEnumerationWritIssuerBase
    {
    }
    }