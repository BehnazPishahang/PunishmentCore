

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PSaftyWritAcceptTransitionBase : PunishmentOrgEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("PHONENUMBER")]
        public virtual string? PhoneNumber { get; set; }

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