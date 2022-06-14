

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Case
{
    public abstract class PTransferCaseBase : PunishmentOrgEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[ForeignKey("DESTINATIONUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheDestinationUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePTransferCase")]
		public virtual List<Anu.PunishmentOrg.Case.PTransferCaseCases>? ThePTransferCaseCasesList { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("SOURCEUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheSourceUnit { get; set; }

    }
    [Table("PTRANSFERCASE")]
    public partial class PTransferCase : PTransferCaseBase { }

    }


