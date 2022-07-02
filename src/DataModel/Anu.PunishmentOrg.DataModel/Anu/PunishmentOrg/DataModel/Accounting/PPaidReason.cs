

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PPaidReasonBase : PunishmentOrgEntity<string>
    {

        [Column("OLDCASEBINDINGIDS")]
        public virtual string? OldCaseBindingIDs { get; set; }

        [Column("PAIDCOST")]
        public virtual long? PaidCost { get; set; }

        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocId { get; set; }

        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [ForeignKey("PBPAIDTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBPaidType? ThePBPaidType { get; set; }

        [ForeignKey("PCASEBINDINGSUBJECTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

        [ForeignKey("PINSTALLMENTDETAILID")]
        public virtual Anu.PunishmentOrg.DataModel.Execution.PInstallmentDetail? ThePInstallmentDetail { get; set; }

        [ForeignKey("PPAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PPaid? ThePPaid { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

    }

    [Table("PPAIDREASON")]
    public partial class PPaidReason : PPaidReasonBase
    {
    }
}