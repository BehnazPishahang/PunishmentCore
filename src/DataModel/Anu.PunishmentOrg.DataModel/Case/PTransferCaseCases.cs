using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PTransferCaseCasesBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PTRANSFERCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PTransferCase? ThePTransferCase { get; set; }

        }

    [Table("PTRANSFERCASECASES")]
    public partial class PTransferCaseCases : PTransferCaseCasesBase
    {
    }
    }