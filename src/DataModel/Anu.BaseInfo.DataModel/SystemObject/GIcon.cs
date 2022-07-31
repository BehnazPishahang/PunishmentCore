

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class GIconBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
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

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GICON")]
    public partial class GIcon : GIconBase
    {
    }
    }