using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PEnumerationWritCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PENUMERATIONWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWrit? ThePEnumerationWrit { get; set; }

        }

    [Table("PENUMERATIONWRITCASE")]
    public partial class PEnumerationWritCase : PEnumerationWritCaseBase
    {
    }
    }