

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class ShortCutKeysBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual long? Code { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("SHORTCUTKEYS")]
    public partial class ShortCutKeys : ShortCutKeysBase
    {
    }
}