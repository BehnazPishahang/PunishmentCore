

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESChangeStateHstBase : BaseInfoEntity<string>
    {

        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("CHANGESECOND")]
        public virtual long? ChangeSecond { get; set; }

        [Column("RELATEDOBJECTID")]
        public virtual string? RelatedObjectId { get; set; }

        [ForeignKey("GFESUSERACCESSID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

        [ForeignKey("NEXTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheNextState { get; set; }

        [ForeignKey("PREVIOUSSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? ThePreviousState { get; set; }

        [ForeignKey("RELATEDFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedForm { get; set; }

        [ForeignKey("RELATEDSYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheRelatedSystemObject { get; set; }

    }

    [Table("GFESCHANGESTATEHST")]
    public partial class GFESChangeStateHst : GFESChangeStateHstBase
    {
    }
}