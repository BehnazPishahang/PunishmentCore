

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Lawyer
{
    public abstract class GLawyerWorkHistoryBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATE")]
        public virtual string? FromDate { get; set; }

        [Column("LAWYERDEGREE")]
        public virtual Anu.BaseInfo.Enumerations.LawyerDegree? LawyerDegree { get; set; }

        [Column("LAWYERSTATE")]
        public virtual Anu.BaseInfo.Enumerations.LawyerState? LawyerState { get; set; }

        [Unicode(false)]
        [Column("LAWYERWORKNO")]
        public virtual string? LawyerWorkNo { get; set; }

        [ForeignKey("GLAWYERID")]
        public virtual Anu.BaseInfo.DataModel.Lawyer.GLawyer? TheGLawyer { get; set; }

        [Unicode(false)]
        [Column("TODATE")]
        public virtual string? ToDate { get; set; }

    }

    [Table("GLAWYERWORKHISTORY")]
    public partial class GLawyerWorkHistory : GLawyerWorkHistoryBase
    {
    }
    }