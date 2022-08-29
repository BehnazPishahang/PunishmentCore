using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PInstallmentBase : PunishmentOrgEntity<string>
    {

        [Column("CONFIRMERPOSTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("INSTALLMENTWARRANTIESINFO")]
        public virtual string? InstallmentWarrantiesInfo { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("NUMINSTALLMENT")]
        public virtual long? NumInstallment { get; set; }

        [Column("PREPAYAMOUNT")]
        public virtual long? PrePayAmount { get; set; }

        [Unicode(false)]
        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePInstallment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PBill4PaidReason>? ThePBill4PaidReasonList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePInstallment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PCashReason>? ThePCashReasonList { get; set; }

        [ForeignKey("PINCOMINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

        [InverseProperty("ThePInstallment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PInstallmentBindingSubject>? ThePInstallmentBindingSubjectList { get; set; }

        [InverseProperty("ThePInstallment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PInstallmentDetail>? ThePInstallmentDetailList { get; set; }

        [InverseProperty("ThePInstallment")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PInstallmentUnit>? ThePInstallmentUnitList { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("SENTENCEDPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? TheSentencedPerson { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("TOTALAMOUNT")]
        public virtual long? TotalAmount { get; set; }

        [Column("TOTALPAIDAMOUNT")]
        public virtual long? TotalPaidAmount { get; set; }

        }

    [Table("PINSTALLMENT")]
    public partial class PInstallment : PInstallmentBase
    {
    }
    }