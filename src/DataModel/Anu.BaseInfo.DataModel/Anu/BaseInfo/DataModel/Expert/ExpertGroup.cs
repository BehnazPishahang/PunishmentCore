

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertGroupBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheExpertGroup")]
        public virtual List<Anu.BaseInfo.DataModel.Expert.ExpertMajor>? TheExpertMajorList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("EXPERTGROUP")]
    public partial class ExpertGroup : ExpertGroupBase
    {
    }
}