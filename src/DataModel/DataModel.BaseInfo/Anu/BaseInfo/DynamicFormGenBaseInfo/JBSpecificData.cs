

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBSpecificDataBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheJBSpecificData")]
		public virtual List<Anu.BaseInfo.DynamicFormGenBaseInfo.JBSpecificDataValue>? TheJBSpecificDataValueList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JBSPECIFICDATA")]
    public partial class JBSpecificData : JBSpecificDataBase { }

    }


