

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBJudgementTemplateTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("FORMTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUFormTemplateType? FormType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBJUDGEMENTTEMPLATETYPE")]
    public partial class PBJudgementTemplateType : PBJudgementTemplateTypeBase
    {
    }
}