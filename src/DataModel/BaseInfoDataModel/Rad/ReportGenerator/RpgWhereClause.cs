

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ReportGenerator
{
    public abstract class RpgWhereClauseBase : BaseInfoEntity<string>
    {

		[Column("COMPUTERDESCRIPTION")]
		public virtual string? ComputerDescription { get; set; }

		[Column("FARSIDESCRIPTION")]
		public virtual string? FarsiDescription { get; set; }

		[ForeignKey("RPGREPORTID")]
		public virtual Rad.ReportGenerator.RpgReport? TheRpgReport { get; set; }

		[InverseProperty("TheRpgWhereClause")]
		public virtual List<Rad.ReportGenerator.RpgWhereTerms>? TheRpgWhereTermsList { get; set; }

    }
    [Table("RPGWHERECLAUSE")]
    public partial class RpgWhereClause : RpgWhereClauseBase { }

    }


