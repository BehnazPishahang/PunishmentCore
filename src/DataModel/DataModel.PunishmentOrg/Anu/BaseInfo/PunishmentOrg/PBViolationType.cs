

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBViolationTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CASESUBJECT")]
		public virtual Anu.Enumerations.PunishmentOrg.PUViolationType? CaseSubject { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LAWDOCUMENT")]
		public virtual string? LawDocument { get; set; }

		[Column("PRODUCTCURRENCY")]
		public virtual Anu.Enumerations.PunishmentOrg.PUProductCurrency? ProductCurrency { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[Column("SUBJECTTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUSubjectTYpe? SubjectType { get; set; }

		[InverseProperty("ThePBViolationType")]
		public virtual List<Anu.BaseInfo.PunishmentOrg.PBViolationTypeInspection>? ThePBViolationTypeInspectionList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBVIOLATIONTYPE")]
    public partial class PBViolationType : PBViolationTypeBase { }

    }


