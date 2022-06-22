

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class SystemObjectBase : BaseInfoEntity<string>
    {

		[Column("ASSEMBLYNAME")]
		public virtual string? AssemblyName { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ENGLISHNAME")]
		public virtual string? EnglishName { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("ROSEID")]
		public virtual string? RoseId { get; set; }

		[Column("SYSTEMOBJECTTYPE")]
		public virtual Anu.Enumerations.SystemObjectType? SystemObjectType { get; set; }

    }
    [Table("SYSTEMOBJECT")]
    public partial class SystemObject : SystemObjectBase { }

    }


