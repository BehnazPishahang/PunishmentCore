

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class AgentTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TEXTTITLE")]
        public virtual string? TextTitle { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Unicode(false)]
        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("AGENTTYPE")]
    public partial class AgentType : AgentTypeBase
    {
    }
    }