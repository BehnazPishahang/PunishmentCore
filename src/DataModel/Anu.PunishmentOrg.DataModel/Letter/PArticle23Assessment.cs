using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PArticle23AssessmentBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ASSESSMENT")]
        public virtual string? Assessment { get; set; }

        [Unicode(false)]
        [Column("ASSESSMENTDATE")]
        public virtual string? AssessmentDate { get; set; }

        [Column("CONSULTANTASSESSMENT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ConsultantAssessment { get; set; }

        [Column("EVALUATOR")]
        public virtual Anu.PunishmentOrg.Enumerations.Evaluator? Evaluator { get; set; }

        [Column("EXPERTASSESSMENT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ExpertAssessment { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PARTICLE23ACTIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PArticle23ActionRequest? ThePArticle23ActionRequest { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        }

    [Table("PARTICLE23ASSESSMENT")]
    public partial class PArticle23Assessment : PArticle23AssessmentBase
    {
    }
    }