

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBCourtMemberBase : PunishmentOrgEntity<string>
    {

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("MEMBERTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUMemberType? MemberType { get; set; }

		[Column("MOBILNUMBER")]
		public virtual string? MobilNumber { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("PRINTORDER")]
		public virtual long? PrintOrder { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBCOURTMEMBER")]
    public partial class PBCourtMember : PBCourtMemberBase { }

    }


