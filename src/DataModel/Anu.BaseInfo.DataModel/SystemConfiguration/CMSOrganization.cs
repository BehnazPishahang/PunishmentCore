using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class CMSOrganizationBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("CMSORGANIZATIONNO")]
        public virtual string? CMSOrganizationNo { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
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