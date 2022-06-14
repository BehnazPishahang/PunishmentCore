

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgWhereTermsBase : BaseInfoEntity<string>
    {

		[Column("ANDOROPERATOR")]
		public virtual Rad.CMS.Enumerations.AndOr? AndOrOperator { get; set; }

		[Column("FIRSTOPERANDATTRIBUTETYPE")]
		public virtual Rad.CMS.Enumerations.RpgAttributeType? FirstOperandAttributeType { get; set; }

		[Column("FIRSTOPERANDTYPE")]
		public virtual Rad.CMS.Enumerations.OperandType? FirstOperandType { get; set; }

		[Column("LEFTOPERAND")]
		public virtual string? LeftOperand { get; set; }

		[Column("LEFTOPERANDDESCRIPTION")]
		public virtual string? LeftOperandDescription { get; set; }

		[Column("LEFTPARENTHESE")]
		public virtual decimal? LeftParenthese { get; set; }

		[Column("OPERATOR")]
		public virtual Rad.CMS.Enumerations.OperatorType? Operator { get; set; }

		[Column("RIGHTOPERAND")]
		public virtual string? RightOperand { get; set; }

		[Column("RIGHTOPERANDDESCRIPTION")]
		public virtual string? RightOperandDescription { get; set; }

		[Column("RIGHTPARENTHESE")]
		public virtual decimal? RightParenthese { get; set; }

		[Column("ROWNO")]
		public virtual decimal? RowNo { get; set; }

		[Column("SECONDOPERANDATTRIBUTETYPE")]
		public virtual Rad.CMS.Enumerations.RpgAttributeType? SecondOperandAttributeType { get; set; }

		[Column("SECONDOPERANDTYPE")]
		public virtual Rad.CMS.Enumerations.OperandType? SecondOperandType { get; set; }

		[ForeignKey("FIRSTOPERANDENMTYPEID")]
		public virtual Rad.ReportGenerator.RpgEnumerations? TheFirstOperandEnmType { get; set; }

		[ForeignKey("RPGWHERECLAUSEID")]
		public virtual Rad.ReportGenerator.RpgWhereClause? TheRpgWhereClause { get; set; }

		[ForeignKey("SECONDOPERANDENMTYPEID")]
		public virtual Rad.ReportGenerator.RpgEnumerations? TheSecondOperandEnmType { get; set; }

    }
    [Table("RPGWHERETERMS")]
    public partial class RpgWhereTerms : RpgWhereTermsBase { }

    }


