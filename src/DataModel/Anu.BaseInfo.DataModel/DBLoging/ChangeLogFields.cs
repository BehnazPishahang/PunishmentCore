

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class ChangeLogFieldsBase : BaseInfoEntity<string>
    {

        [Column("BLOBFIELDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.LOBFieldType? BLOBFieldType { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NOWBLOBDATA")]
        public virtual byte[]? NowBLOBData { get; set; }

        [Unicode(false)]
        [Column("NOWCLOBDATA")]
        public virtual string? NowCLOBData { get; set; }

        [Unicode(false)]
        [Column("NOWDATA")]
        public virtual string? NowData { get; set; }

        [Column("PREVIOUSBLOBDATA")]
        public virtual byte[]? PreviousBLOBData { get; set; }

        [Unicode(false)]
        [Column("PREVIOUSCLOBDATA")]
        public virtual string? PreviousCLOBData { get; set; }

        [Unicode(false)]
        [Column("PREVIOUSDATA")]
        public virtual string? PreviousData { get; set; }

        [Unicode(false)]
        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [Unicode(false)]
        [Column("SYSTEMFORMID")]
        public virtual string? SystemFormId { get; set; }

        [ForeignKey("CHANGELOGMAINDOCID")]
        public virtual Anu.BaseInfo.DataModel.DBLoging.ChangeLogMainDoc? TheChangeLogMainDoc { get; set; }

        [ForeignKey("RELATEDSYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }

    [Table("CHANGELOGFIELDS")]
    public partial class ChangeLogFields : ChangeLogFieldsBase
    {
    }
    }