

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class CaseServerBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("COMPUTERNAME")]
        public virtual string? ComputerName { get; set; }

        [Unicode(false)]
        [Column("IP")]
        public virtual string? IP { get; set; }

        [Column("ISCURRENTSERVER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsCurrentServer { get; set; }

        [Column("ISRELTOCENTRAL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRelToCentral { get; set; }

        [Unicode(false)]
        [Column("MANAGERSERVERIP")]
        public virtual string? ManagerServerIP { get; set; }

        [Column("SERVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ServerType? ServerType { get; set; }

        [Unicode(false)]
        [Column("SYNCURL")]
        public virtual string? SyncUrl { get; set; }

        [InverseProperty("TheCaseServer")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization>? TheCMSOrganizationList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("CASESERVER")]
    public partial class CaseServer : CaseServerBase
    {
    }
    }