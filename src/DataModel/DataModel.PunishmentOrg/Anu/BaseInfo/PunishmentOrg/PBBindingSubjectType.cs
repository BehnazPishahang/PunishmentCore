

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBBindingSubjectTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("IS4GOODSCURRENCY")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? Is4GoodsCurrency { get; set; }

		[Column("PENALTYTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUPenaltyType? PenaltyType { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBBINDINGSUBJECTTYPE")]
    public partial class PBBindingSubjectType : PBBindingSubjectTypeBase { }

    }


