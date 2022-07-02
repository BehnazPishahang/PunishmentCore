

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class GIconBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("MOUSEOVERICON")]
        public virtual byte[]? MouseOverIcon { get; set; }

        [Column("NORMALICON")]
        public virtual byte[]? NormalIcon { get; set; }

        [Column("SELECTIONICON")]
        public virtual byte[]? SelectionIcon { get; set; }

        [InverseProperty("TheGIcon")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.Menu>? TheMenuList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GICON")]
    public partial class GIcon : GIconBase
    {
    }
}