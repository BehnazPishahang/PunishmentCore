﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class ECMServerBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("COMPUTERNAME")]
        public virtual string? ComputerName { get; set; }

        [Column("ECMSERVICEURL")]
        public virtual string? ECMServiceUrl { get; set; }

        [Column("IP")]
        public virtual string? IP { get; set; }

        [InverseProperty("TheECMServer")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization>? TheCMSOrganizationList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("ECMSERVER")]
    public partial class ECMServer : ECMServerBase
    {
    }
}