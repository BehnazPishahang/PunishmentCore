

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PTransferCaseCasesBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PTRANSFERCASEID")]
		public virtual Anu.PunishmentOrg.Case.PTransferCase? ThePTransferCase { get; set; }

    }
    [Table("PTRANSFERCASECASES")]
    public partial class PTransferCaseCases : PTransferCaseCasesBase { }

    }


