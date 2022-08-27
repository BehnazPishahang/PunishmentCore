using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemTemplateObjectBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Unicode(false)]
        [Column("LATINNAME")]
        public virtual string? LatinName { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [Column("TYPE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowDataType? Type { get; set; }

        }

    [Table("SYSTEMTEMPLATEOBJECT")]
    public partial class SystemTemplateObject : SystemTemplateObjectBase
    {
    }
    }