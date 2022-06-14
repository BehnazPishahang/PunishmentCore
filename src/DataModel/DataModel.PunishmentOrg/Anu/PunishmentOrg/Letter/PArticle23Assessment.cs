

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class PArticle23AssessmentBase : PunishmentOrgEntity<string>
    {

		[Column("ASSESSMENT")]
		public virtual string? Assessment { get; set; }

		[Column("ASSESSMENTDATE")]
		public virtual string? AssessmentDate { get; set; }

		[Column("CONSULTANTASSESSMENT")]
		public virtual Anu.Enumerations.YesNo? ConsultantAssessment { get; set; }

		[Column("EVALUATOR")]
		public virtual Anu.Enumerations.PunishmentOrg.Evaluator? Evaluator { get; set; }

		[Column("EXPERTASSESSMENT")]
		public virtual Anu.Enumerations.YesNo? ExpertAssessment { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[ForeignKey("PARTICLE23ACTIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PArticle23ActionRequest? ThePArticle23ActionRequest { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("PARTICLE23ASSESSMENT")]
    public partial class PArticle23Assessment : PArticle23AssessmentBase { }

    }


