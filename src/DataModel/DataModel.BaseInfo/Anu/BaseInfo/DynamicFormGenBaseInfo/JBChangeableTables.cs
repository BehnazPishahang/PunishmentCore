

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBChangeableTablesBase : BaseInfoEntity<string>
    {

		[ForeignKey("TABLEONEID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheTableOne { get; set; }

		[ForeignKey("TABLETWOID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheTableTwo { get; set; }

    }
    [Table("JBCHANGEABLETABLES")]
    public partial class JBChangeableTables : JBChangeableTablesBase { }

    }


