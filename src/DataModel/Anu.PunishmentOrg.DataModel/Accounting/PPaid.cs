

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PPaidBase : PunishmentOrgEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("CHECKFICHEDATE")]
        public virtual string? CheckFicheDate { get; set; }

        [Column("CHECKFICHENO")]
        public virtual string? CheckFicheNo { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

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

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("PAIDPERSONTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUAccountPersonType? PaidPersonType { get; set; }

        [Column("PERSONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

        [Column("SEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

        [Column("SIDENOTE")]
        public virtual string? SideNote { get; set; }

        [ForeignKey("ACCOUNTSID")]
        public virtual Anu.BaseInfo.DataModel.Types.Accounts? TheAccounts { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [InverseProperty("ThePPaid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidDoc>? ThePPaidDocList { get; set; }

        [InverseProperty("ThePPaid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidReason>? ThePPaidReasonList { get; set; }

        [InverseProperty("ThePPaid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidRelatedCash>? ThePPaidRelatedCashList { get; set; }

        [InverseProperty("ThePPaid")]
        public virtual List<Anu.PunishmentOrg.DataModel.Accounting.PPaidUnit>? ThePPaidUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("TOTALPAIDCOST")]
        public virtual long? TotalPaidCost { get; set; }

    }

    [Table("PPAID")]
    public partial class PPaid : PPaidBase
    {
    }
}