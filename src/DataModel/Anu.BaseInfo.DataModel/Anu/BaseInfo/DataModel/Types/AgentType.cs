

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class AgentTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TEXTTITLE")]
        public virtual string? TextTitle { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("AGENTTYPE")]
    public partial class AgentType : AgentTypeBase
    {
    }
}