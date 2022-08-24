using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedCaseBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CMSNO")]
        public virtual string? CMSNo { get; set; }

        [Unicode(false)]
        [Column("CONFIRMDATETIME")]
        public virtual string? ConfirmDateTime { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DESTROYEDNO")]
        public virtual string? DestroyedNo { get; set; }

        [Unicode(false)]
        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Unicode(false)]
        [Column("ENDYEAR")]
        public virtual string? EndYear { get; set; }

        [Column("PAGENUMBER")]
        public virtual long? PageNumber { get; set; }

        [Column("STEPNO")]
        public virtual Anu.PunishmentOrg.Enumerations.DestroyedCaseStep? StepNo { get; set; }

        [ForeignKey("CONFIRMERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheConfirmer { get; set; }

        [ForeignKey("MAKHTUMEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.Makhtume? TheMakhtume { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PBOXFILEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PBoxFile? ThePBoxFile { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePDestroyedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCaseImages>? ThePDestroyedCaseImagesList { get; set; }

        [InverseProperty("ThePDestroyedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCaseOffending>? ThePDestroyedCaseOffendingList { get; set; }

        [InverseProperty("ThePDestroyedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCasePlaintiff>? ThePDestroyedCasePlaintiffList { get; set; }

        [InverseProperty("ThePDestroyedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCaseViolation>? ThePDestroyedCaseViolationList { get; set; }

        [InverseProperty("ThePDestroyedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCaseWrap>? ThePDestroyedCaseWrapList { get; set; }

        [InverseProperty("ThePDestroyedCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedJudge>? ThePDestroyedJudgeList { get; set; }

        [ForeignKey("REGISTRARID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegistrar { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("PDESTROYEDCASE")]
    public partial class PDestroyedCase : PDestroyedCaseBase
    {
    }
    }