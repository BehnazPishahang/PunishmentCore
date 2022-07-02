

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PEnumerationWritBase : PunishmentOrgEntity<string>
    {

        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("EXEPRSFAMILY")]
        public virtual string? ExePrsFamily { get; set; }

        [Column("EXEPRSFATHERNAME")]
        public virtual string? ExePrsFatherName { get; set; }

        [Column("EXEPRSNAME")]
        public virtual string? ExePrsName { get; set; }

        [Column("EXEPRSNATIONALCODE")]
        public virtual string? ExePrsNationalCode { get; set; }

        [Column("EXPERTPRICE")]
        public virtual long? ExpertPrice { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePEnumerationWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritCase>? ThePEnumerationWritCaseList { get; set; }

        [InverseProperty("ThePEnumerationWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritExpert>? ThePEnumerationWritExpertList { get; set; }

        [InverseProperty("ThePEnumerationWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritIssuer>? ThePEnumerationWritIssuerList { get; set; }

        [InverseProperty("ThePEnumerationWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritUnit>? ThePEnumerationWritUnitList { get; set; }

        [InverseProperty("ThePEnumerationWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PEnumerationWritWrapCase>? ThePEnumerationWritWrapCaseList { get; set; }

        [ForeignKey("PINCOMINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("WRITDATE")]
        public virtual string? WritDate { get; set; }

        [Column("WRITTEXT")]
        public virtual string? WritText { get; set; }

        [Column("WRITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUEnumerationWritType? WritType { get; set; }

    }

    [Table("PENUMERATIONWRIT")]
    public partial class PEnumerationWrit : PEnumerationWritBase
    {
    }
}