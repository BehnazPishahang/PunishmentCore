using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsTradeUnitBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("BIRTHDATE")]
        public virtual string? BirthDate { get; set; }

        [Unicode(false)]
        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Unicode(false)]
        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONNO")]
        public virtual string? InspectionNo { get; set; }

        [Unicode(false)]
        [Column("MOBILNUMBER")]
        public virtual string? MobilNumber { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Unicode(false)]
        [Column("REFERENCETIME")]
        public virtual string? ReferenceTime { get; set; }

        [Column("RESULT")]
        public virtual Anu.PunishmentOrg.Enumerations.PUMobilePatrolsResult? Result { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [ForeignKey("PBREGULATORYPLANID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBRegulatoryPlan? ThePBRegulatoryPlan { get; set; }

        [ForeignKey("PBTRADEUNIONSID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnions? ThePBTradeUnions { get; set; }

        [ForeignKey("PBTRADEUNITTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBTradeUnitType? ThePBTradeUnitType { get; set; }

        [ForeignKey("PMOBILEPATROLSID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrols? ThePMobilePatrols { get; set; }

        [InverseProperty("ThePMobilePatrolsTradeUnit")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTUAttachment>? ThePMobilePatrolsTUAttachmentList { get; set; }

        [InverseProperty("ThePMobilePatrolsTradeUnit")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTUProduct>? ThePMobilePatrolsTUProductList { get; set; }

        [InverseProperty("ThePMobilePatrolsTradeUnit")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTUPunishment>? ThePMobilePatrolsTUPunishmentList { get; set; }

        [InverseProperty("ThePMobilePatrolsTradeUnit")]
        public virtual List<Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTUViolation>? ThePMobilePatrolsTUViolationList { get; set; }

        [Unicode(false)]
        [Column("TRADELICENSEDATE")]
        public virtual string? TradeLicenseDate { get; set; }

        [Unicode(false)]
        [Column("TRADELICENSENUMBER")]
        public virtual string? TradeLicenseNumber { get; set; }

        }

    [Table("PMOBILEPATROLSTRADEUNIT")]
    public partial class PMobilePatrolsTradeUnit : PMobilePatrolsTradeUnitBase
    {
    }
    }