

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableReportFieldChgFieldsBase : BaseInfoEntity<string>
    {

		[ForeignKey("CHANGEFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheChangeField { get; set; }

    }
    [Table("JTABLEREPORTFIELDCHGFIELDS")]
    public partial class JTableReportFieldChgFields : JTableReportFieldChgFieldsBase { }

    }


