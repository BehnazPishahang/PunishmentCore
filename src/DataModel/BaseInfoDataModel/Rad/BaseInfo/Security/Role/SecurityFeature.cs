

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Role
{
    public abstract class SecurityFeatureBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LATINNAME")]
		public virtual string? LatinName { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

    }
    [Table("SECURITYFEATURE")]
    public partial class SecurityFeature : SecurityFeatureBase { }

    }


