

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
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
		public virtual Rad.CMS.Enumerations.SystemObjectType? SystemObjectType { get; set; }

		[InverseProperty("TheSystemObject")]
		public virtual List<Rad.BaseInfo.Security.Position.BasePosition>? TheBasePositionList { get; set; }

		[InverseProperty("TheSystemObject")]
		public virtual List<Rad.BaseInfo.SystemObject.ObjectState>? TheObjectStateList { get; set; }

    }
    [Table("SYSTEMOBJECT")]
    public partial class SystemObject : SystemObjectBase { }

    }


