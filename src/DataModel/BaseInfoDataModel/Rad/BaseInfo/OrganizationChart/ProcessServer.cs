

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class ProcessServerBase : BaseInfoEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("FATHERNAME")]
		public virtual string? FatherName { get; set; }

		[Column("HOMEADDRESS")]
		public virtual string? HomeAddress { get; set; }

		[Column("IDENTITYNO")]
		public virtual string? IdentityNo { get; set; }

		[Column("JOBTITE")]
		public virtual string? JobTite { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALITYCODE")]
		public virtual string? NationalityCode { get; set; }

		[Column("PROCESSSERVERTYPE")]
		public virtual Rad.CMS.Enumerations.ProcessServerType? ProcessServerType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("BIRTHLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheBirthLocation { get; set; }

		[ForeignKey("ISSUELOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheIssueLocation { get; set; }

    }
    [Table("PROCESSSERVER")]
    public partial class ProcessServer : ProcessServerBase { }

    }


