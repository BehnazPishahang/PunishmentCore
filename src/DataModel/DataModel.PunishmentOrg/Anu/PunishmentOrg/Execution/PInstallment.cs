

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PInstallmentBase : PunishmentOrgEntity<string>
    {

		[Column("CONFIRMERPOSTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("INSTALLMENTWARRANTIESINFO")]
		public virtual string? InstallmentWarrantiesInfo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NUMINSTALLMENT")]
		public virtual long? NumInstallment { get; set; }

		[Column("PREPAYAMOUNT")]
		public virtual long? PrePayAmount { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePInstallment")]
		public virtual List<Anu.PunishmentOrg.Accounting.PBill4PaidReason>? ThePBill4PaidReasonList { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePInstallment")]
		public virtual List<Anu.PunishmentOrg.Accounting.PCashReason>? ThePCashReasonList { get; set; }

		[ForeignKey("PINCOMINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

		[InverseProperty("ThePInstallment")]
		public virtual List<Anu.PunishmentOrg.Execution.PInstallmentBindingSubject>? ThePInstallmentBindingSubjectList { get; set; }

		[InverseProperty("ThePInstallment")]
		public virtual List<Anu.PunishmentOrg.Execution.PInstallmentDetail>? ThePInstallmentDetailList { get; set; }

		[InverseProperty("ThePInstallment")]
		public virtual List<Anu.PunishmentOrg.Execution.PInstallmentUnit>? ThePInstallmentUnitList { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("SENTENCEDPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? TheSentencedPerson { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TOTALAMOUNT")]
		public virtual long? TotalAmount { get; set; }

		[Column("TOTALPAIDAMOUNT")]
		public virtual long? TotalPaidAmount { get; set; }

    }
    [Table("PINSTALLMENT")]
    public partial class PInstallment : PInstallmentBase { }

    }


