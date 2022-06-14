

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Lawyer
{
    public abstract class GLawyerWorkHistoryBase : BaseInfoEntity<string>
    {

		[Column("FROMDATE")]
		public virtual string? FromDate { get; set; }

		[Column("LAWYERDEGREE")]
		public virtual Anu.Enumerations.LawyerDegree? LawyerDegree { get; set; }

		[Column("LAWYERSTATE")]
		public virtual Anu.Enumerations.LawyerState? LawyerState { get; set; }

		[Column("LAWYERWORKNO")]
		public virtual string? LawyerWorkNo { get; set; }

		[ForeignKey("GLAWYERID")]
		public virtual Anu.BaseInfo.Lawyer.GLawyer? TheGLawyer { get; set; }

		[Column("TODATE")]
		public virtual string? ToDate { get; set; }

    }
    [Table("GLAWYERWORKHISTORY")]
    public partial class GLawyerWorkHistory : GLawyerWorkHistoryBase { }

    }


