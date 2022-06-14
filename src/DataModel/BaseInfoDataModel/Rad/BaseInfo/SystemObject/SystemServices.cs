

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class SystemServicesBase : BaseInfoEntity<string>
    {

		[Column("ACTIONNAME")]
		public virtual string? ActionName { get; set; }

		[Column("CONTROLLERNAME")]
		public virtual string? ControllerName { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("RELATEDCODE")]
		public virtual string? RelatedCode { get; set; }

		[Column("RELATEDORGANIZATION")]
		public virtual string? RelatedOrganization { get; set; }

		[Column("ROUTE")]
		public virtual string? Route { get; set; }

    }
    [Table("SYSTEMSERVICES")]
    public partial class SystemServices : SystemServicesBase { }

    }


