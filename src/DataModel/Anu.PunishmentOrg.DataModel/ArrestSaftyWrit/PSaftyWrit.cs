

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PSaftyWritBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ENDCREDITDATE")]
        public virtual string? EndCreditDate { get; set; }

        [Column("MANUALNO")]
        public virtual string? ManualNo { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("SAFTYWRITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSaftyWritType? SaftyWritType { get; set; }

        [ForeignKey("BASEWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWrit? TheBaseWrit { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePSaftyWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PArrested>? ThePArrestedList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [InverseProperty("ThePSaftyWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritAccept>? ThePSaftyWritAcceptList { get; set; }

        [InverseProperty("ThePSaftyWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritIssuer>? ThePSaftyWritIssuerList { get; set; }

        [InverseProperty("ThePSaftyWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWritUnit>? ThePSaftyWritUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("VALUETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSaftyWritValueType? ValueType { get; set; }

        [Column("WRITAMOUNT")]
        public virtual long? WritAmount { get; set; }

        [Column("WRITDATE")]
        public virtual string? WritDate { get; set; }

        [Column("WRITTEXT")]
        public virtual string? WritText { get; set; }

    }

    [Table("PSAFTYWRIT")]
    public partial class PSaftyWrit : PSaftyWritBase
    {
    }
}