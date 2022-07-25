

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticePersonBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("EXPERTMANID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMan? TheExpertMan { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PNOTICEID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNotice? ThePNotice { get; set; }

    }

    [Table("PNOTICEPERSON")]
    public partial class PNoticePerson : PNoticePersonBase
    {
    }
}