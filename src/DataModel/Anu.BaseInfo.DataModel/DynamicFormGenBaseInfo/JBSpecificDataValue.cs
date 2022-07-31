

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBSpecificDataValueBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectID { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("JBSPECIFICDATAID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBSpecificData? TheJBSpecificData { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("JBSPECIFICDATAVALUE")]
    public partial class JBSpecificDataValue : JBSpecificDataValueBase
    {
    }
    }