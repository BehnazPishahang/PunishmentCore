using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class ShortCutKeysBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual long? Code { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("SHORTCUTKEYS")]
    public partial class ShortCutKeys : ShortCutKeysBase
    {
    }
    }