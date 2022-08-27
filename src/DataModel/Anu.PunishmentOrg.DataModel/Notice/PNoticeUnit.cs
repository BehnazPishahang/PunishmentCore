using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PNOTICEID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNotice? ThePNotice { get; set; }

        }

    [Table("PNOTICEUNIT")]
    public partial class PNoticeUnit : PNoticeUnitBase
    {
    }
    }