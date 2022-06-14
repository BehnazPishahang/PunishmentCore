

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class GeneralOrganizationBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CMSORGANIZATIONNO")]
		public virtual string? CMSOrganizationNo { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("ORGANIZATIONID")]
		public virtual string? OrganizationID { get; set; }

		[Column("ORGANIZATIONTYPE")]
		public virtual Rad.CMS.Enumerations.GeneralOrganizationType? OrganizationType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

    }
    [Table("GENERALORGANIZATION")]
    public partial class GeneralOrganization : GeneralOrganizationBase { }

    }


