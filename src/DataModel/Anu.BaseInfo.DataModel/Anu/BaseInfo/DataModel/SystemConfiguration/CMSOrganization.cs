

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class CMSOrganizationBase : BaseInfoEntity<string>
    {

        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("CMSORGANIZATIONNO")]
        public virtual string? CMSOrganizationNo { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

        [ForeignKey("ECMSERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.ECMServer? TheECMServer { get; set; }

        [InverseProperty("TheCMSOrganization")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory>? TheRegisterUserHistoryList { get; set; }

        [ForeignKey("SCRIPTORIUMID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Scriptorium? TheScriptorium { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("CMSORGANIZATION")]
    public partial class CMSOrganization : CMSOrganizationBase
    {
    }
}