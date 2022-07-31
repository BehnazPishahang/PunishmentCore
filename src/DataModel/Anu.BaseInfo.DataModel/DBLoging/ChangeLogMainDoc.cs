

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class ChangeLogMainDocBase : BaseInfoEntity<string>
    {

        [Column("ISBASEFORMOBJECT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsBaseFormObject { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [ForeignKey("CHANGEDATATYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.ChangeDataType? TheChangeDataType { get; set; }

        [ForeignKey("CHANGELOGID")]
        public virtual Anu.BaseInfo.DataModel.DBLoging.ChangeLog? TheChangeLog { get; set; }

        [InverseProperty("TheChangeLogMainDoc")]
        public virtual List<Anu.BaseInfo.DataModel.DBLoging.ChangeLogFields>? TheChangeLogFieldsList { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("CHANGELOGMAINDOC")]
    public partial class ChangeLogMainDoc : ChangeLogMainDocBase
    {
    }
    }