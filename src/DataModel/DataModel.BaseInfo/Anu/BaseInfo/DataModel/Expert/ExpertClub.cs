

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertClubBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("EXPERTCLUB")]
    public partial class ExpertClub : ExpertClubBase
    {
    }
}