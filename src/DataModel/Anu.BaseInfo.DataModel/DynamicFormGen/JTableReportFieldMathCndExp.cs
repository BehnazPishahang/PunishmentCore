﻿

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldMathCndExpBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CONDITIONEXP")]
        public virtual string? ConditionExp { get; set; }

        [Unicode(false)]
        [Column("FIELDMATHEXP")]
        public virtual string? FieldMathExp { get; set; }

        [Column("ISROUND")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRound { get; set; }

        [Unicode(false)]
        [Column("LOOKUPWHERECOND")]
        public virtual string? LookupWhereCond { get; set; }

        [Column("ORDERNO")]
        public virtual decimal? OrderNo { get; set; }

        [Column("ROUNDDIGITNUM")]
        public virtual decimal? RoundDigitNum { get; set; }

        [Unicode(false)]
        [Column("SCRIPTEXP")]
        public virtual string? ScriptExp { get; set; }

        [InverseProperty("TheJTableReportFieldMathCndExp")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldMathCond>? TheJTableReportFieldMathCondList { get; set; }

        [InverseProperty("TheJTableReportFieldMathCndExp")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldMathExp>? TheJTableReportFieldMathExpList { get; set; }

        [ForeignKey("MAINFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheMainField { get; set; }

    }

    [Table("JTABLEREPORTFIELDMATHCNDEXP")]
    public partial class JTableReportFieldMathCndExp : JTableReportFieldMathCndExpBase
    {
    }
    }