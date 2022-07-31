

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PTransferCaseBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [ForeignKey("DESTINATIONUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheDestinationUnit { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePTransferCase")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PTransferCaseCases>? ThePTransferCaseCasesList { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [ForeignKey("SOURCEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheSourceUnit { get; set; }

    }

    [Table("PTRANSFERCASE")]
    public partial class PTransferCase : PTransferCaseBase
    {
    }
    }