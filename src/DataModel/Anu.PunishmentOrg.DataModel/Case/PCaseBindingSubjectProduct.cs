using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseBindingSubjectProductBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PCASEPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseProduct? ThePCaseProduct { get; set; }

        }

    [Table("PCASEBINDINGSUBJECTPRODUCT")]
    public partial class PCaseBindingSubjectProduct : PCaseBindingSubjectProductBase
    {
    }
    }