

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PSaftyWritAcceptTransitionBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Unicode(false)]
        [Column("PHONENUMBER")]
        public virtual string? PhoneNumber { get; set; }

        [Unicode(false)]
        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("PSAFTYWRITACCEPTID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritAccept? ThePSaftyWritAccept { get; set; }

        [ForeignKey("TRANSITIONCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? TheTransitionCasePerson { get; set; }

        [Column("TRANSITIONPERSONTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSaftyWritAcceptTransitionPersonType? TransitionPersonType { get; set; }

    }

    [Table("PSAFTYWRITACCEPTTRANSITION")]
    public partial class PSaftyWritAcceptTransition : PSaftyWritAcceptTransitionBase
    {
    }
    }