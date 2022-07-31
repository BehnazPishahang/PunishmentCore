

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PCancelSaftyWritBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("SAFTYWRITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSaftyWritType? SaftyWritType { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePCancelSaftyWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PCancelSaftyWritIssuer>? ThePCancelSaftyWritIssuerList { get; set; }

        [InverseProperty("ThePCancelSaftyWrit")]
        public virtual List<Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PCancelSaftyWritUnit>? ThePCancelSaftyWritUnitList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PCASEPERSONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCasePerson? ThePCasePerson { get; set; }

        [ForeignKey("PSAFTYWRITID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PSaftyWrit? ThePSaftyWrit { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("WRITAMOUNT")]
        public virtual long? WritAmount { get; set; }

        [Unicode(false)]
        [Column("WRITDATE")]
        public virtual string? WritDate { get; set; }

        [Unicode(false)]
        [Column("WRITTEXT")]
        public virtual string? WritText { get; set; }

    }

    [Table("PCANCELSAFTYWRIT")]
    public partial class PCancelSaftyWrit : PCancelSaftyWritBase
    {
    }
    }