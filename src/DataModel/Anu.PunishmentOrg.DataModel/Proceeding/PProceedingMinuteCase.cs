using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PProceedingMinuteCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PPROCEEDINGMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinute? ThePProceedingMinute { get; set; }

        }

    [Table("PPROCEEDINGMINUTECASE")]
    public partial class PProceedingMinuteCase : PProceedingMinuteCaseBase
    {
    }
    }