

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class ObjectStateBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATETYPE")]
        public virtual Anu.BaseInfo.Enumerations.StateType? StateType { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("UNITLEVELACCESS")]
        public virtual string? UnitLevelAccess { get; set; }

    }

    [Table("OBJECTSTATE")]
    public partial class ObjectState : ObjectStateBase
    {
    }
}