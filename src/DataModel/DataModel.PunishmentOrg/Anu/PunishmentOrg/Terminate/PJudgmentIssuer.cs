

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentIssuerBase : PunishmentOrgEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("MEMBERTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUMemberType? MemberType { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("PRINTORDER")]
		public virtual long? PrintOrder { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PJUDGMENTISSUER")]
    public partial class PJudgmentIssuer : PJudgmentIssuerBase { }

    }


