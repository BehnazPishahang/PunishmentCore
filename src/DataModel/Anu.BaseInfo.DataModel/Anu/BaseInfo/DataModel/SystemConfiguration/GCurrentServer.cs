

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class GCurrentServerBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [ForeignKey("CURCMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCurCMSOrganization { get; set; }

        [ForeignKey("CURSERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCurServer { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GCURRENTSERVER")]
    public partial class GCurrentServer : GCurrentServerBase
    {
    }
}