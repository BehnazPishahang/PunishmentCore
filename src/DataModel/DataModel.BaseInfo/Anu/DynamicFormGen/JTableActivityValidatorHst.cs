

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableActivityValidatorHstBase : BaseInfoEntity<string>
    {

		[Column("FROMCHANGEDATETIME")]
		public virtual string? FromChangeDateTime { get; set; }

		[Column("FROMMILISECOND")]
		public virtual string? FromMiliSecond { get; set; }

		[ForeignKey("JBDLLREGISTERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

		[ForeignKey("JTABLEREPORTACTIVITYID")]
		public virtual Anu.DynamicFormGen.JTableReportActivity? TheJTableReportActivity { get; set; }

		[Column("TOCHANGEDATETIME")]
		public virtual string? ToChangeDateTime { get; set; }

		[Column("TOMILISECOND")]
		public virtual string? ToMiliSecond { get; set; }

    }
    [Table("JTABLEACTIVITYVALIDATORHST")]
    public partial class JTableActivityValidatorHst : JTableActivityValidatorHstBase { }

    }


