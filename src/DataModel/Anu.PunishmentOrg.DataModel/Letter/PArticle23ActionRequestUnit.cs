using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PArticle23ActionRequestUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PARTICLE23ACTIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PArticle23ActionRequest? ThePArticle23ActionRequest { get; set; }

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        }

    [Table("PARTICLE23ACTIONREQUESTUNIT")]
    public partial class PArticle23ActionRequestUnit : PArticle23ActionRequestUnitBase
    {
    }
    }