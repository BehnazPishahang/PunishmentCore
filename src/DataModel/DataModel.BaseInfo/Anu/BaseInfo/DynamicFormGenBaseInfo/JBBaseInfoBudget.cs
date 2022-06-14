

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBBaseInfoBudgetBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("CODELENGTH")]
		public virtual decimal? CodeLength { get; set; }

		[Column("OTHERFIELDS")]
		public virtual string? OtherFields { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheOldRec")]
		public virtual List<Anu.BaseInfo.DynamicFormGenBaseInfo.JBBaseInfoBudgetConnections>? TheNewConnRecordsList { get; set; }

		[InverseProperty("TheNewRec")]
		public virtual List<Anu.BaseInfo.DynamicFormGenBaseInfo.JBBaseInfoBudgetConnections>? TheOldConnRecordsList { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JBBASEINFOBUDGET")]
    public partial class JBBaseInfoBudget : JBBaseInfoBudgetBase { }

    }


