

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.DynamicFormGenBaseInfo
{
    public abstract class JBDLLRegisterBase : BaseInfoEntity<string>
    {

		[Column("ASSEMBLYNAME")]
		public virtual string? AssemblyName { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FULLNAME")]
		public virtual string? FullName { get; set; }

		[Column("METHODTYPE")]
		public virtual Anu.Enumerations.MethodType? MethodType { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("JBDLLREGISTER")]
    public partial class JBDLLRegister : JBDLLRegisterBase { }

    }


