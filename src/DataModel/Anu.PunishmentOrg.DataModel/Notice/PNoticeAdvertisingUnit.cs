using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeAdvertisingUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PNOTICEADVERTISINGID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

        }

    [Table("PNOTICEADVERTISINGUNIT")]
    public partial class PNoticeAdvertisingUnit : PNoticeAdvertisingUnitBase
    {
    }
    }