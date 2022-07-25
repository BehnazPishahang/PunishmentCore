﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBViolationTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CASESUBJECT")]
        public virtual Anu.PunishmentOrg.Enumerations.PUViolationType? CaseSubject { get; set; }

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("LAWDOCUMENT")]
        public virtual string? LawDocument { get; set; }

        [Column("PRODUCTCURRENCY")]
        public virtual Anu.PunishmentOrg.Enumerations.PUProductCurrency? ProductCurrency { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("SUBJECTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSubjectTYpe? SubjectType { get; set; }

        [InverseProperty("ThePBViolationType")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationTypeInspection>? ThePBViolationTypeInspectionList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBVIOLATIONTYPE")]
    public partial class PBViolationType : PBViolationTypeBase
    {
    }
}