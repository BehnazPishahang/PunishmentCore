

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SpeakTemplateBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("REASONATTACH")]
        public virtual string? ReasonAttach { get; set; }

        [Column("RELIEFACCUSE")]
        public virtual string? ReliefAccuse { get; set; }

        [Column("SPEAK")]
        public virtual string? Speak { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("SPEAKTEMPLATE")]
    public partial class SpeakTemplate : SpeakTemplateBase
    {
    }
}