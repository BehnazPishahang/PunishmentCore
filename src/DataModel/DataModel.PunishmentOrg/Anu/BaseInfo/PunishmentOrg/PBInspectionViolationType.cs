

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBInspectionViolationTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CASESUBJECT")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUViolationType? CaseSubject { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[InverseProperty("ThePBInspectionViolationType")]
		public virtual List<Anu.BaseInfo.PunishmentOrg.PBViolationTypeInspection>? ThePBViolationTypeInspectionList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBINSPECTIONVIOLATIONTYPE")]
    public partial class PBInspectionViolationType : PBInspectionViolationTypeBase { }

    }


