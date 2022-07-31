

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PRevisionRequestTripleBase : PunishmentOrgEntity<string>
    {

        [Column("ISCONFIRM")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsConfirm { get; set; }

        [ForeignKey("PCASETRIPLEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseTriple? ThePCaseTriple { get; set; }

        [ForeignKey("PREVISIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

    }

    [Table("PREVISIONREQUESTTRIPLE")]
    public partial class PRevisionRequestTriple : PRevisionRequestTripleBase
    {
    }
    }