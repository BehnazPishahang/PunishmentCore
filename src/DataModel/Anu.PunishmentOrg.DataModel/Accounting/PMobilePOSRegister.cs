

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PMobilePOSRegisterBase : PunishmentOrgEntity<string>
    {

        [Column("RECEIVERNO")]
        public virtual string? ReceiverNo { get; set; }

        [Column("TERMINALID")]
        public virtual string? TerminalID { get; set; }

        [ForeignKey("ACCOUNTSID")]
        public virtual Anu.BaseInfo.DataModel.Types.Accounts? TheAccounts { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PMOBILEPOSREGISTER")]
    public partial class PMobilePOSRegister : PMobilePOSRegisterBase
    {
    }
}