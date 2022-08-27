using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SpeakTemplateBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("REASONATTACH")]
        public virtual string? ReasonAttach { get; set; }

        [Unicode(false)]
        [Column("RELIEFACCUSE")]
        public virtual string? ReliefAccuse { get; set; }

        [Unicode(false)]
        [Column("SPEAK")]
        public virtual string? Speak { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("SPEAKTEMPLATE")]
    public partial class SpeakTemplate : SpeakTemplateBase
    {
    }
    }