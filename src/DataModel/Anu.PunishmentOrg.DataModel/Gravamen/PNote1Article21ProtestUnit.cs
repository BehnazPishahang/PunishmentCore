using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PNote1Article21ProtestUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [ForeignKey("PNOTE1ARTICLE21PROTESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PNote1Article21Protest? ThePNote1Article21Protest { get; set; }

        }

    [Table("PNOTE1ARTICLE21PROTESTUNIT")]
    public partial class PNote1Article21ProtestUnit : PNote1Article21ProtestUnitBase
    {
    }
    }