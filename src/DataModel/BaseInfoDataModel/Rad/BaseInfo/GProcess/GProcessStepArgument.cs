

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessStepArgumentBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual decimal? Code { get; set; }

		[Column("DATATYPE")]
		public virtual Rad.CMS.Enumerations.GArgumentDataType? DataType { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("INPUTOUTPUT")]
		public virtual Rad.CMS.Enumerations.GArgumentType? InputOutput { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

		[InverseProperty("TheGProcessStepArgument")]
		public virtual List<Rad.BaseInfo.GProcess.GRequestArgumentValue>? TheGRequestArgumentValueList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GPROCESSSTEPARGUMENT")]
    public partial class GProcessStepArgument : GProcessStepArgumentBase { }

    }


