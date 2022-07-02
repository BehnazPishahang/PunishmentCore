

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PInterimVisibleCaseBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ENDDATE")]
        public virtual string? EndDate { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [ForeignKey("INTERIMVISIBLEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheInterimVisibleUnit { get; set; }

        [ForeignKey("OWNERCASEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheOwnerCaseUnit { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("PINTERIMVISIBLECASE")]
    public partial class PInterimVisibleCase : PInterimVisibleCaseBase
    {
    }
}