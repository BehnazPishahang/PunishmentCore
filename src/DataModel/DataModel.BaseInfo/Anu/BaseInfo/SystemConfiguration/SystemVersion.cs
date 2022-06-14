

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemConfiguration
{
    public abstract class SystemVersionBase : BaseInfoEntity<string>
    {

		[Column("SYSTEMNAME")]
		public virtual string? SystemName { get; set; }

		[Column("VERSIONNO")]
		public virtual string? VersionNo { get; set; }

    }
    [Table("SYSTEMVERSION")]
    public partial class SystemVersion : SystemVersionBase { }

    }


