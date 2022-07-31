

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class ECMServerBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("COMPUTERNAME")]
        public virtual string? ComputerName { get; set; }

        [Unicode(false)]
        [Column("ECMSERVICEURL")]
        public virtual string? ECMServiceUrl { get; set; }

        [Unicode(false)]
        [Column("IP")]
        public virtual string? IP { get; set; }

        [InverseProperty("TheECMServer")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization>? TheCMSOrganizationList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("ECMSERVER")]
    public partial class ECMServer : ECMServerBase
    {
    }
    }